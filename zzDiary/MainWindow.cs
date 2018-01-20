using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zzDiary
{
    public partial class MainWindow : Form
    {
        private Diary diary;

        public MainWindow(Diary _diary)
        {
            diary = _diary;
            InitializeComponent();
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            diary.FirstLoad();
        }

        public void UpdateDate(string year, string month, string day)
        {
            YearBox.Text = year;
            MonthBox.Text = month;
            DayBox.Text = day;
        }

        public void BindList(BindingList<string> list)
        {
            EntryList.DataSource = list;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            diary.SaveEdit(EntryList.SelectedIndex, DayBox.Text, TitleBox.Text, ContentBox.Text);
        }

        private void EntryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EntryList.SelectedIndex == -1)
            {
                return;
            }
            Entry entry = diary.LoadEntry(EntryList.SelectedIndex);
            DayBox.Text = entry.Day.ToString("D2");
            TitleBox.Text = entry.Title;
            ContentBox.Text = entry.Content;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            diary.CreateNewEntry();
        }
    }
}
