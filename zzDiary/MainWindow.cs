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
        private bool contentChanged = false;
        private int entryIndex = 0;

        public MainWindow(Diary _diary)
        {
            diary = _diary;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            diary.FirstLoad();
            DisplayEntry(0);
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
            contentChanged = false;
            diary.SaveEdit(EntryList.SelectedIndex, DayBox.Text, TitleBox.Text, ContentBox.Text);
        }

        private void EntryList_Click(object sender, EventArgs e)
        {
            if (EntryList.SelectedIndex >=0)
            {
                if (entryIndex != EntryList.SelectedIndex)
                {
                    CheckContentChange();
                    DisplayEntry(EntryList.SelectedIndex);
                    entryIndex = EntryList.SelectedIndex;
                }
            }
        }
        
        private void EntryList_SelectedIndexChanged(object sender,EventArgs e)
        {
            if (EntryList.SelectedIndex >= 0)
            {
                    DisplayEntry(EntryList.SelectedIndex);
                    entryIndex = EntryList.SelectedIndex;
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            EntryList.SelectedIndex = diary.CreateNewEntry();
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
            CheckContentChange();
        }

        private void MonthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            diary.SetCurrentMonth(Int32.Parse(MonthList.SelectedItem.ToString()));
            diary.LoadMonth();
            CheckContentChange();
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


        private void DayBox_TextChanged(object sender, EventArgs e)
        {
            CheckEdit(DayBox);
        }


        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            CheckEdit(TitleBox);
        }

        private void ContentBox_TextChanged(object sender, EventArgs e)
        {
            CheckEdit(ContentBox);
        }

        private void CheckEdit(Control ctrl)
        {
            if (ctrl == ActiveControl)
            {
                if (!contentChanged)
                {
                    contentChanged = true;
                }
            }
        }

        private void CheckContentChange()
        {
            if (contentChanged)
            {
                contentChanged = false;
                //diary.SaveEdit(entryIndex, DayBox.Text, TitleBox.Text, ContentBox.Text);
            }
        }

        public void DisplayEntry(int index)
        {
            Entry entry = diary.LoadEntry(index);
            if (entry != null)
            {
                DayBox.Text = entry.Day.ToString("D2");
                TitleBox.Text = entry.Title;
                ContentBox.Text = entry.Content;
            }
        }

        public void DisplayEmpty()
        {
            DayBox.Text = "";
            TitleBox.Text = "";
            ContentBox.Text = "";
        }

    }
}
