using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Xceed.Words.NET;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;

namespace zzDiary
{
    public partial class ParseWindow : Form
    {
        private Diary diary;
        private const string parsePath = "D:\\Dropbox\\Diary";
        private char[] dividers = { '[', ']', '【', '】' ,'(',')'};
        private string[] chineseMonth = {
            "一月","二月","三月","四月","五月","六月","七月","八月","九月","十月","十一月","十二月"
        };



        public ParseWindow(Diary _diary)
        {
            InitializeComponent();
            diary = _diary;
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            LogBox.Text = "";

            if (YearBox.Text != "" && MonthBox.Text != "")
            {
                string monthPath = "";

                if (ChineseCheckBox.Checked)
                {
                    monthPath = parsePath + "\\" + YearBox.Text + "\\" + chineseMonth[Int32.Parse(MonthBox.Text)-1] + "\\";
                }
                else
                {
                    monthPath = parsePath + "\\" + YearBox.Text + "\\" + MonthBox.Text + "\\";
                }

                
                AddLog("Opening " + monthPath);
                string [] allFiles = Directory.GetFiles(monthPath);
                bool monthSet = false;
                
                for (int i = 0; i < allFiles.Length; i++)
                {
                    string filePath = allFiles[i];
                    string fileName = filePath.Replace(monthPath, "");
                    AddLog("Parsing " + fileName);
                    
                    string [] split = fileName.Split(dividers);

                    Microsoft.Office.Interop.Word.Application wordApp = null;

                    if (split.Length > 2)
                    {
                        string date = split[1];
                        AddLog("Date = " + date);
                        if (!monthSet)
                        {
                            string yearStr = date.Substring(0, 2);
                            string monthStr = date.Substring(2, 2);
                            int yearInt = Int32.Parse(yearStr) + 2000;
                            int monthInt = Int32.Parse(monthStr);
                            diary.SetCurrentYearMonth(yearInt, monthInt);
                            diary.LoadMonth();
                            monthSet = true;
                            AddLog("Setting Year = " + yearInt + " Month = " + monthInt);
                        }
                        string dayStr = date.Substring(4, 2);
                        int dayInt = Int32.Parse(dayStr);
                        AddLog("Day = " + dayInt);

                        string title = split[2].Split('.')[0];

                        if (title.Length > 0 && title.ToCharArray()[0] == ' ')
                        {
                            title = title.Substring(1);
                        }

                        string extension = split[2].Split('.')[1];
                        AddLog("Title = " + title);
                        AddLog("Extension = " + extension);
                        
                        if (extension == "txt")
                        {
                            parseTxt(filePath, dayStr, title);
                        }else if (extension == "docx")
                        {
                            parseDocx(filePath, dayStr, title);
                            
                        }else if (extension == "doc")
                        {
                            if (wordApp == null)
                            {
                                wordApp = new Microsoft.Office.Interop.Word.Application();
                            }
                            parseDoc(wordApp, filePath, dayStr, title);   
                           
                           
                        }
                        
                        diary.SortList();

                        AddLog("--------");

                    }

                    if (wordApp != null)
                    {
                        wordApp.Quit();
                    }
                    
                }

            }
        }

        private void parseTxt(string filePath,string dayStr,string title)
        {
            byte[] contentRaw = File.ReadAllBytes(filePath);

            string gbk = System.Text.Encoding.GetEncoding(936).GetString(contentRaw);
            string utf8 = System.Text.Encoding.UTF8.GetString(contentRaw);

            int entryIndex = diary.CreateNewEntry();
            if (utf8.Contains('�'))
            {
                AddLog(gbk);
                diary.SaveEdit(entryIndex, dayStr, title, gbk);
            }
            else
            {
                AddLog(utf8);
                diary.SaveEdit(entryIndex, dayStr, title, utf8);
            }
        }

        private void parseDocx(string filePath, string dayStr,string title)
        {
            string content = "";

            using (DocX document = DocX.Load(File.OpenRead(filePath)))
            {
                for (int j = 0; j < document.Paragraphs.Count; j++)
                {
                    Xceed.Words.NET.Paragraph p = document.Paragraphs.ElementAt(j);
                    content += p.Text;
                    content += "\r\n";
                }

            }

            int entryIndex = diary.CreateNewEntry();
            AddLog(content);
            diary.SaveEdit(entryIndex, dayStr, title, content);
        }

        private void parseDoc(Microsoft.Office.Interop.Word.Application wordApp, string filePath, string dayStr, string title)
        {
            Document doc = wordApp.Documents.Open(filePath);
            string content = doc.Range().Text;
            content = content.Replace("\r", "\r\n");
            int entryIndex = diary.CreateNewEntry();
            AddLog(content);
            diary.SaveEdit(entryIndex, dayStr, title, content);
            doc.Close();
        }

        private void AddLog(string text)
        {
            text += "\r\n";
            LogBox.Text += text; 
        }
    }
}
