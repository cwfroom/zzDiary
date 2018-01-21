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
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.YearList = new System.Windows.Forms.ListBox();
            this.MonthList = new System.Windows.Forms.ListBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryList
            // 
            this.EntryList.FormattingEnabled = true;
            this.EntryList.ItemHeight = 25;
            this.EntryList.Location = new System.Drawing.Point(12, 12);
            this.EntryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EntryList.Name = "EntryList";
            this.EntryList.Size = new System.Drawing.Size(296, 629);
            this.EntryList.TabIndex = 1;
            this.EntryList.SelectedIndexChanged += new System.EventHandler(this.EntryList_SelectedIndexChanged);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(408, 13);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(653, 32);
            this.TitleBox.TabIndex = 3;
            // 
            // ContentBox
            // 
            this.ContentBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContentBox.Location = new System.Drawing.Point(314, 52);
            this.ContentBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(747, 589);
            this.ContentBox.TabIndex = 4;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(315, 13);
            this.YearBox.MaxLength = 2;
            this.YearBox.Name = "YearBox";
            this.YearBox.ReadOnly = true;
            this.YearBox.Size = new System.Drawing.Size(29, 32);
            this.YearBox.TabIndex = 7;
            this.YearBox.Text = "00";
            // 
            // MonthBox
            // 
            this.MonthBox.Location = new System.Drawing.Point(344, 13);
            this.MonthBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MonthBox.MaxLength = 2;
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.ReadOnly = true;
            this.MonthBox.Size = new System.Drawing.Size(29, 32);
            this.MonthBox.TabIndex = 8;
            this.MonthBox.Text = "00";
            // 
            // DayBox
            // 
            this.DayBox.Location = new System.Drawing.Point(373, 13);
            this.DayBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DayBox.MaxLength = 2;
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(29, 32);
            this.DayBox.TabIndex = 2;
            this.DayBox.Text = "00";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1115, 599);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 40);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(1115, 414);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(91, 40);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(1115, 460);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(91, 40);
            this.UpButton.TabIndex = 6;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(1115, 506);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(91, 40);
            this.DownButton.TabIndex = 7;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1115, 553);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 40);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 655);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1264, 26);
            this.StatusStrip.TabIndex = 10;
            this.StatusStrip.Text = "Status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(57, 21);
            this.StatusLabel.Text = "Status";
            // 
            // YearList
            // 
            this.YearList.FormattingEnabled = true;
            this.YearList.ItemHeight = 25;
            this.YearList.Location = new System.Drawing.Point(1078, 13);
            this.YearList.Name = "YearList";
            this.YearList.Size = new System.Drawing.Size(80, 304);
            this.YearList.TabIndex = 11;
            
            // 
            // MonthList
            // 
            this.MonthList.FormattingEnabled = true;
            this.MonthList.ItemHeight = 25;
            this.MonthList.Location = new System.Drawing.Point(1169, 13);
            this.MonthList.Name = "MonthList";
            this.MonthList.Size = new System.Drawing.Size(80, 304);
            this.MonthList.TabIndex = 12;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(1115, 368);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(91, 40);
            this.ParseButton.TabIndex = 13;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.MonthList);
            this.Controls.Add(this.YearList);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.EntryList);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.Text = "zzDiary";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindowKeyPress);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
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
        private Button ParseButton;
    }
}

