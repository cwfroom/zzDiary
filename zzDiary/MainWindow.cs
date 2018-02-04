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

        public void SetYearMonth(int[] years, int[] months)
        {

            YearList.DataSource = years;
            MonthList.DataSource = months;
            this.YearList.SelectedIndexChanged += new System.EventHandler(this.YearList_SelectedIndexChanged);
            this.MonthList.SelectedIndexChanged += new System.EventHandler(this.MonthList_SelectedIndexChanged);
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
            EntryList.SelectedIndex =  diary.CreateNewEntry();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EntryList.SelectedIndex = diary.DeleteEntry(EntryList.SelectedIndex);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            EntryList.SelectedIndex = diary.MoveUpEntry(EntryList.SelectedIndex);
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            EntryList.SelectedIndex = diary.MoveDownEntry(EntryList.SelectedIndex);
        }

        private void MainWindowKeyPress(object sender, KeyPressEventArgs e)
        {
            this.KeyDown += new KeyEventHandler(this.MainWindowKeyDown);
           
        }

        private void MainWindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                diary.SaveEdit(EntryList.SelectedIndex, DayBox.Text, TitleBox.Text, ContentBox.Text);
            }
        }

        public void UpdateStatus(string status)
        {
            StatusLabel.Text = status + " " + DateTime.Now.ToLongTimeString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            ParseWindow pw = new ParseWindow(diary);
            pw.ShowDialog();
        }

        private void YearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            diary.SetCurrentYear(Int32.Parse(YearList.SelectedItem.ToString()));
            diary.LoadMonth();
        }

        private void MonthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            diary.SetCurrentMonth(Int32.Parse(MonthList.SelectedItem.ToString()));
            diary.LoadMonth();
        }

        public void UpdateYearMonthList(int yearIndex, int monthIndex)
        {
            YearList.SelectedIndex = yearIndex;
            MonthList.SelectedIndex = monthIndex;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            diary.SortList();
        }
    }
}
