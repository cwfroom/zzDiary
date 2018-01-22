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

namespace zzDiary
{
    public partial class ParseWindow : Form
    {
        private Diary diary;
        private const string parsePath = "D:\\Dropbox\\Diary";
        private char[] dividers = { '[', ']', '【', '】' };

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
                string monthPath = parsePath + "\\" + YearBox.Text + "\\" + MonthBox.Text + "\\";
                AddLog("Opening " + monthPath);
                string [] allFiles = Directory.GetFiles(monthPath);
                
                for (int i = 0; i < allFiles.Length; i++)
                {
                    string filePath = allFiles[i];
                    string fileName = filePath.Replace(monthPath, "");
                    AddLog("Parsing " + fileName);
                    
                    string [] split = fileName.Split(dividers);
                    
                    if (split.Length > 1)
                    {
                        string date = split[1];
                        AddLog("Date = " + date);
                        if (i == 0)
                        {
                            string yearStr = date.Substring(0, 2);
                            string monthStr = date.Substring(2, 2);
                            int yearInt = Int32.Parse(yearStr) + 2000;
                            int monthInt = Int32.Parse(monthStr);
                            diary.SetCurrentYearMonth(yearInt, monthInt);
                            diary.LoadMonth();
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
                        }else if (extension == "docx")
                        {
                            string content = "";

                            using (DocX document = DocX.Load(File.OpenRead(filePath)))
                            {
                                for (int j= 0; j < document.Paragraphs.Count; j++)
                                {
                                    Paragraph p = document.Paragraphs.ElementAt(j);
                                    content += p.Text;
                                    content += "\r\n";
                                }
                                
                            }

                            int entryIndex = diary.CreateNewEntry();
                            AddLog(content);
                            diary.SaveEdit(entryIndex, dayStr, title, content);
                            
                        }

                        

                        diary.SortList();

                        AddLog("--------");

                    }
                    
                }

            }
        }

        private void AddLog(string text)
        {
            text += "\r\n";
            LogBox.Text += text; 
        }
    }
}
