using System;
using System.Windows.Forms;

namespace zzDiary
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.EntryList = new System.Windows.Forms.ListBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.TextBox();
            this.DayBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.WordCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.YearList = new System.Windows.Forms.ListBox();
            this.MonthList = new System.Windows.Forms.ListBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.DiaryPage = new System.Windows.Forms.TabPage();
            this.LogbookPage = new System.Windows.Forms.TabPage();
            this.StatusStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.DiaryPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryList
            // 
            this.EntryList.FormattingEnabled = true;
            this.EntryList.ItemHeight = 21;
            this.EntryList.Location = new System.Drawing.Point(6, 1);
            this.EntryList.Name = "EntryList";
            this.EntryList.Size = new System.Drawing.Size(269, 508);
            this.EntryList.TabIndex = 1;
            this.EntryList.SelectedIndexChanged += new System.EventHandler(this.EntryList_SelectedIndexChanged);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(368, 2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(607, 28);
            this.TitleBox.TabIndex = 3;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // ContentBox
            // 
            this.ContentBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContentBox.Location = new System.Drawing.Point(281, 37);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(694, 470);
            this.ContentBox.TabIndex = 4;
            this.ContentBox.TextChanged += new System.EventHandler(this.ContentBox_TextChanged);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(281, 2);
            this.YearBox.MaxLength = 2;
            this.YearBox.Name = "YearBox";
            this.YearBox.ReadOnly = true;
            this.YearBox.Size = new System.Drawing.Size(27, 28);
            this.YearBox.TabIndex = 7;
            this.YearBox.Text = "00";
            // 
            // MonthBox
            // 
            this.MonthBox.Location = new System.Drawing.Point(308, 2);
            this.MonthBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MonthBox.MaxLength = 2;
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.ReadOnly = true;
            this.MonthBox.Size = new System.Drawing.Size(27, 28);
            this.MonthBox.TabIndex = 8;
            this.MonthBox.Text = "00";
            // 
            // DayBox
            // 
            this.DayBox.Location = new System.Drawing.Point(335, 2);
            this.DayBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DayBox.MaxLength = 2;
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(27, 28);
            this.DayBox.TabIndex = 2;
            this.DayBox.Text = "00";
            this.DayBox.TextChanged += new System.EventHandler(this.DayBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1016, 468);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(83, 34);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(1016, 268);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(83, 34);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(1016, 308);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(83, 34);
            this.UpButton.TabIndex = 6;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(1016, 348);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(83, 34);
            this.DownButton.TabIndex = 7;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1016, 388);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(83, 34);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordCountLabel,
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 546);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1149, 26);
            this.StatusStrip.TabIndex = 10;
            this.StatusStrip.Text = "Status";
            // 
            // WordCountLabel
            // 
            this.WordCountLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordCountLabel.Name = "WordCountLabel";
            this.WordCountLabel.Size = new System.Drawing.Size(99, 21);
            this.WordCountLabel.Text = "WordCount";
            this.WordCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(57, 21);
            this.StatusLabel.Text = "Status";
            // 
            // YearList
            // 
            this.YearList.FormattingEnabled = true;
            this.YearList.ItemHeight = 21;
            this.YearList.Location = new System.Drawing.Point(981, 2);
            this.YearList.Name = "YearList";
            this.YearList.Size = new System.Drawing.Size(73, 256);
            this.YearList.TabIndex = 11;
            // 
            // MonthList
            // 
            this.MonthList.FormattingEnabled = true;
            this.MonthList.ItemHeight = 21;
            this.MonthList.Location = new System.Drawing.Point(1060, 2);
            this.MonthList.Name = "MonthList";
            this.MonthList.Size = new System.Drawing.Size(73, 256);
            this.MonthList.TabIndex = 12;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(1016, 428);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(83, 34);
            this.SortButton.TabIndex = 14;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.DiaryPage);
            this.TabControl.Controls.Add(this.LogbookPage);
            this.TabControl.Location = new System.Drawing.Point(0, -1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1149, 544);
            this.TabControl.TabIndex = 15;
            // 
            // DiaryPage
            // 
            this.DiaryPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DiaryPage.Controls.Add(this.EntryList);
            this.DiaryPage.Controls.Add(this.YearBox);
            this.DiaryPage.Controls.Add(this.MonthList);
            this.DiaryPage.Controls.Add(this.MonthBox);
            this.DiaryPage.Controls.Add(this.YearList);
            this.DiaryPage.Controls.Add(this.DayBox);
            this.DiaryPage.Controls.Add(this.TitleBox);
            this.DiaryPage.Controls.Add(this.ContentBox);
            this.DiaryPage.Controls.Add(this.DeleteButton);
            this.DiaryPage.Controls.Add(this.DownButton);
            this.DiaryPage.Controls.Add(this.UpButton);
            this.DiaryPage.Controls.Add(this.NewButton);
            this.DiaryPage.Controls.Add(this.SortButton);
            this.DiaryPage.Controls.Add(this.SaveButton);
            this.DiaryPage.Location = new System.Drawing.Point(4, 30);
            this.DiaryPage.Name = "DiaryPage";
            this.DiaryPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiaryPage.Size = new System.Drawing.Size(1141, 510);
            this.DiaryPage.TabIndex = 0;
            this.DiaryPage.Text = "Diary";
            // 
            // LogbookPage
            // 
            this.LogbookPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogbookPage.Location = new System.Drawing.Point(4, 30);
            this.LogbookPage.Name = "LogbookPage";
            this.LogbookPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogbookPage.Size = new System.Drawing.Size(1141, 510);
            this.LogbookPage.TabIndex = 1;
            this.LogbookPage.Text = "Logbook";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 572);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusStrip);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1165, 611);
            this.MinimumSize = new System.Drawing.Size(1165, 611);
            this.Name = "MainWindow";
            this.Text = "zzDiary";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindowKeyPress);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.DiaryPage.ResumeLayout(false);
            this.DiaryPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ListBox EntryList;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox MonthBox;
        private System.Windows.Forms.TextBox DayBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button DeleteButton;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel StatusLabel;
        private ListBox YearList;
        private ListBox MonthList;
        private Button SortButton;
        private ToolStripStatusLabel WordCountLabel;
        private TabControl TabControl;
        private TabPage DiaryPage;
        private TabPage LogbookPage;
    }
}

