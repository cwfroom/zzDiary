namespace zzDiary
{
    partial class ParseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParseWindow));
            this.YearBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.TextBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ChineseCheckBox = new System.Windows.Forms.CheckBox();
            this.ByTextCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(13, 13);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(147, 32);
            this.YearBox.TabIndex = 0;
            this.YearBox.Text = "2002";
            // 
            // MonthBox
            // 
            this.MonthBox.Location = new System.Drawing.Point(12, 51);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(148, 32);
            this.MonthBox.TabIndex = 1;
            this.MonthBox.Text = "12";
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(166, 13);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(606, 536);
            this.LogBox.TabIndex = 2;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(12, 511);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(100, 38);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ChineseCheckBox
            // 
            this.ChineseCheckBox.AutoSize = true;
            this.ChineseCheckBox.Location = new System.Drawing.Point(13, 90);
            this.ChineseCheckBox.Name = "ChineseCheckBox";
            this.ChineseCheckBox.Size = new System.Drawing.Size(147, 29);
            this.ChineseCheckBox.TabIndex = 4;
            this.ChineseCheckBox.Text = "ChineseDate";
            this.ChineseCheckBox.UseVisualStyleBackColor = true;
            // 
            // ByTextCheckBox
            // 
            this.ByTextCheckBox.AutoSize = true;
            this.ByTextCheckBox.Checked = true;
            this.ByTextCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ByTextCheckBox.Location = new System.Drawing.Point(12, 126);
            this.ByTextCheckBox.Name = "ByTextCheckBox";
            this.ByTextCheckBox.Size = new System.Drawing.Size(92, 29);
            this.ByTextCheckBox.TabIndex = 5;
            this.ByTextCheckBox.Text = "ByText";
            this.ByTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // ParseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ByTextCheckBox);
            this.Controls.Add(this.ChineseCheckBox);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.YearBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ParseWindow";
            this.Text = "Archive Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox MonthBox;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.CheckBox ChineseCheckBox;
        private System.Windows.Forms.CheckBox ByTextCheckBox;
    }
}