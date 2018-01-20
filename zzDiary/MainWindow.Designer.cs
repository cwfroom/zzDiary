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
            this.EntryList = new System.Windows.Forms.ListBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.TextBox();
            this.DayBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntryList
            // 
            this.EntryList.FormattingEnabled = true;
            this.EntryList.ItemHeight = 25;
            this.EntryList.Location = new System.Drawing.Point(12, 12);
            this.EntryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EntryList.Name = "EntryList";
            this.EntryList.Size = new System.Drawing.Size(296, 654);
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
            this.ContentBox.Size = new System.Drawing.Size(747, 616);
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
            this.SaveButton.Location = new System.Drawing.Point(1110, 626);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 40);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(1110, 580);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(91, 40);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.EntryList);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.Text = "zzDiary";
            this.Load += new System.EventHandler(this.MainWindow_Load);
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
    }
}

