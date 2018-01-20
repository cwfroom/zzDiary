﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using Newtonsoft.Json;

namespace zzDiary
{
    public class Config {
        public string DataPath { get; set; }
        public int FirstYear { get; set; }
    }

    public class Entry {
        public int Day { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Entry(int _Day, string _Title,string _Content)
        {
            Day = _Day;
            Title = _Title;
            Content = _Content;
        }
        public Entry()
        {
            Day = 0;
            Title = "";
            Content = "";
        }
    }

    public class EntryDisplay {
        string DisplayTitle { get; set; }
        public EntryDisplay(string year, string month, Entry entry)
        {
            DisplayTitle = "[" + year + month + entry.Day.ToString("D2") + "] " + entry.Title;
        }
    }


    public class EntryList
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public List<Entry> List { get; set; }
        public EntryList(int _Year, int _Month)
        {
            Year = _Year;
            Month = _Month;
            List = new List<Entry>();
        }
    }



    public class Diary
    {
        private const string configFileName = "config.zzd";
        private Config config;

        private EntryList currentList;
        public BindingList<string> DisplayList;
        private int currentYear;
        private int currentMonth;
        private int currentDay;
        private string currentYearStr;
        private string currentMonthStr;
        private string currentDayStr;
        private string currentYearPath;
        private string currentMonthPath;

        private List<int> yearList;
        private List<int> monthList;

        private MainWindow mainWindow;
        

        public Diary()
        {
            config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configFileName));
            if (config.FirstYear == 0)
            {
                MessageBox.Show("Failed to load configuration file", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Environment.Exit(1);
            }
            
        }

    
        public Form InitializeUI()
        {
            mainWindow = new MainWindow(this);
            return mainWindow;
        }
        
        private void SetCurrentDate(int year,int month,int day)
        {
            currentYear = year;
            currentMonth = month;
            currentDay = day;
            currentYearStr = (year%100).ToString("D2");
            currentMonthStr = month.ToString("D2");
            currentDayStr = day.ToString("D2");

            currentYearPath = config.DataPath + "\\" + currentYear;
            currentMonthPath = config.DataPath + "\\" + currentYear + "\\" + currentMonthStr + ".zzd";
        }

        public void FirstLoad()
        {
            SetCurrentDate(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            mainWindow.UpdateDate(currentYearStr,currentMonthStr,currentDayStr);
            LoadMonth();
        }

        public void LoadMonth()
        {
            Console.WriteLine(currentMonthPath);

            if (!File.Exists(currentMonthPath))
            {
                CreateNewMonth();
            }
            else
            {
                currentList = JsonConvert.DeserializeObject<EntryList>(File.ReadAllText(currentMonthPath));
            }

            DisplayList = new BindingList<string>();
            foreach (Entry entry in currentList.List)
            {
                DisplayList.Add(GetDisplayTitle(entry));
            }

            mainWindow.BindList(DisplayList);

        }

        private string GetDisplayTitle(Entry entry)
        {
            if (entry.Day == 0)
            {
                return entry.Title;
            }
            else
            {
                return "[" + currentYearStr + currentMonthStr + entry.Day.ToString("D2") + "] " + entry.Title;
            }
            
        }

        public Entry LoadEntry(int index)
        {
            return currentList.List[index];
        }

        public void CreateNewMonth()
        {
            Entry dummyEntry = new Entry();
            currentList = new EntryList(currentYear,currentMonth);
            currentList.List.Add(dummyEntry);

            if (!Directory.Exists(currentYearPath)){
                Directory.CreateDirectory(currentYearPath);
            }

            SaveFile();   
        }

        public void CreateNewEntry()
        {
            Entry newEntry = new Entry(currentDay, "", "");
            int i;
            for (i = 0; i < currentList.List.Count; i++)
            {
                if (LoadEntry(i).Day != 0 && currentDay > LoadEntry(i).Day)
                {
                    break;
                }
            }

            currentList.List.Insert(i, newEntry);
            DisplayList.Insert(i,GetDisplayTitle(newEntry));
        }


        public void SaveEdit(int index, string day, string title, string content)
        {
            Entry entry = LoadEntry(index);

            entry.Day = Int32.Parse(day);
            entry.Title = title;
            entry.Content = content;
            DisplayList[index] = GetDisplayTitle(entry);
            SaveFile();
        }

        public void SaveFile()
        {
            using (StreamWriter sw = File.CreateText(currentMonthPath))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, currentList);
            }

        }
        

    }
}