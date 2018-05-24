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
        private char[] dividers = { '[', ']', '【', '】' };
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
            if (ByTextCheckBox.Checked)
            {
                parseFromText();
            }
            else
            {
                parseFromPath();
            }
            
        }

        private void parseFromText()
        {
            string[] paragraphs = LogBox.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string title, content;
            title = content = string.Empty;
            int year, month;
            string day = string.Empty;
            year = month = 0;
            for (int i = 0; i < paragraphs.Length; i++)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(paragraphs[i], @"\[\d{6}\]") || System.Text.RegularExpressions.Regex.IsMatch(paragraphs[i], @"\【\d{6}\】"))
                {
                    if (content != string.Empty)
                    {
                        diary.SetCurrentYearMonth(year, month);
                        diary.LoadMonth();
                        diary.SaveEdit(diary.CreateNewEntry(), day, title, content);
                        content = string.Empty;
                    }

                    string [] dateAndTitle = paragraphs[i].Split(dividers);
                    string date = dateAndTitle[1];
                    title = dateAndTitle[2];
                    if (title.ToCharArray()[0] == ' ')
                    {
                        title = title.Substring(1, title.Length - 1);
                    }
                    year = Int32.Parse(date.Substring(0, 2)) + 2000;
                    month = Int32.Parse(date.Substring(2, 2));
                    day = date.Substring(4, 2);
                }
                else
                {
                    content += paragraphs[i];
                    content += "\r\n";
                }
                
            }

            int j = 0;
            diary.SetCurrentYearMonth(year, month);
            diary.LoadMonth();
            content = content.Substring(0, content.Length - 2);
            diary.SaveEdit(diary.CreateNewEntry(), day, title, content);
            diary.SortList();
        }

        private void parseFromPath()
        {
            LogBox.Text = "";

            if (YearBox.Text != "" && MonthBox.Text != "")
            {
                string monthPath = "";

                if (ChineseCheckBox.Checked)
                {
                    monthPath = parsePath + "\\" + YearBox.Text + "\\" + chineseMonth[Int32.Parse(MonthBox.Text) - 1] + "\\";
                }
                else
                {
                    monthPath = parsePath + "\\" + YearBox.Text + "\\" + MonthBox.Text + "\\";
                }


                int yearInt = Int32.Parse(YearBox.Text);
                int monthInt = Int32.Parse(MonthBox.Text);

                diary.SetCurrentYearMonth(yearInt, monthInt);
                diary.LoadMonth();
                AddLog("Setting Year = " + yearInt + " Month = " + monthInt);

                AddLog("Opening " + monthPath);
                string[] allFiles = Directory.GetFiles(monthPath);

                Microsoft.Office.Interop.Word.Application wordApp = null;

                for (int i = 0; i < allFiles.Length; i++)
                {
                    string filePath = allFiles[i];
                    string fileName = filePath.Replace(monthPath, "");
                    AddLog("Parsing " + fileName);

                    string[] split = fileName.Split(dividers);

                    string date = "0";
                    string dayStr = "0";
                    string title = "";
                    string extension = "";
                    if (split.Length > 2 && System.Text.RegularExpressions.Regex.IsMatch(split[1], @"^\d+$"))
                    {
                        date = split[1];
                        dayStr = date.Substring(4, 2);
                        title = split[2].Split('.')[0];
                        extension = split[2].Split('.')[1];
                    }
                    else
                    {
                        title = fileName.Split('.')[0];
                        extension = fileName.Split('.')[1];
                    }
                    int dayInt = Int32.Parse(dayStr);
                    if (title.Length > 0 && title.ToCharArray()[0] == ' ')
                    {
                        title = title.Substring(1);
                    }

                    AddLog("Date = " + date);
                    AddLog("Day = " + dayInt);
                    AddLog("Title = " + title);
                    AddLog("Extension = " + extension);

                    if (extension == "txt")
                    {
                        parseTxt(filePath, dayStr, title);
                    }
                    else if (extension == "docx")
                    {
                        if (wordApp == null)
                        {
                            wordApp = new Microsoft.Office.Interop.Word.Application();
                        }
                        parseDoc(wordApp, filePath, dayStr, title);
                        //parseDocx(filePath, dayStr, title);
                    }
                    else if (extension == "doc")
                    {
                        if (wordApp == null)
                        {
                            wordApp = new Microsoft.Office.Interop.Word.Application();
                        }
                        parseDoc(wordApp, filePath, dayStr, title);
                    }

                }

                diary.SortList();
                AddLog("--------");

                if (wordApp != null)
                {
                    wordApp.Quit();
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
                    if (j != document.Paragraphs.Count - 1)
                    {
                        content += "\r\n";
                    }
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
