namespace DevToolBoxOne.Forms.Converter
{
	partial class ShamsiDate_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShamsiDate_FRM));
            this.Title_LBL = new System.Windows.Forms.Label();
            this.Year_LBL = new System.Windows.Forms.Label();
            this.Month_LBL = new System.Windows.Forms.Label();
            this.Day_LBL = new System.Windows.Forms.Label();
            this.Year_TB = new System.Windows.Forms.TextBox();
            this.Month_TB = new System.Windows.Forms.TextBox();
            this.Day_TB = new System.Windows.Forms.TextBox();
            this.UserDate_LBL = new System.Windows.Forms.Label();
            this.InsertDate_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_LBL
            // 
            this.Title_LBL.AutoSize = true;
            this.Title_LBL.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Title_LBL.Location = new System.Drawing.Point(12, 9);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(131, 19);
            this.Title_LBL.TabIndex = 0;
            this.Title_LBL.Text = "Enter Date Data:";
            // 
            // Year_LBL
            // 
            this.Year_LBL.AutoSize = true;
            this.Year_LBL.Location = new System.Drawing.Point(14, 40);
            this.Year_LBL.Name = "Year_LBL";
            this.Year_LBL.Size = new System.Drawing.Size(44, 19);
            this.Year_LBL.TabIndex = 1;
            this.Year_LBL.Text = "Year:";
            // 
            // Month_LBL
            // 
            this.Month_LBL.AutoSize = true;
            this.Month_LBL.Location = new System.Drawing.Point(14, 73);
            this.Month_LBL.Name = "Month_LBL";
            this.Month_LBL.Size = new System.Drawing.Size(53, 19);
            this.Month_LBL.TabIndex = 2;
            this.Month_LBL.Text = "Month:";
            // 
            // Day_LBL
            // 
            this.Day_LBL.AutoSize = true;
            this.Day_LBL.Location = new System.Drawing.Point(14, 104);
            this.Day_LBL.Name = "Day_LBL";
            this.Day_LBL.Size = new System.Drawing.Size(37, 19);
            this.Day_LBL.TabIndex = 3;
            this.Day_LBL.Text = "Day:";
            // 
            // Year_TB
            // 
            this.Year_TB.BackColor = System.Drawing.SystemColors.Info;
            this.Year_TB.Location = new System.Drawing.Point(80, 38);
            this.Year_TB.Name = "Year_TB";
            this.Year_TB.Size = new System.Drawing.Size(100, 27);
            this.Year_TB.TabIndex = 4;
            // 
            // Month_TB
            // 
            this.Month_TB.BackColor = System.Drawing.SystemColors.Info;
            this.Month_TB.Location = new System.Drawing.Point(80, 73);
            this.Month_TB.Name = "Month_TB";
            this.Month_TB.Size = new System.Drawing.Size(100, 27);
            this.Month_TB.TabIndex = 5;
            // 
            // Day_TB
            // 
            this.Day_TB.BackColor = System.Drawing.SystemColors.Info;
            this.Day_TB.Location = new System.Drawing.Point(80, 106);
            this.Day_TB.Name = "Day_TB";
            this.Day_TB.Size = new System.Drawing.Size(100, 27);
            this.Day_TB.TabIndex = 6;
            // 
            // UserDate_LBL
            // 
            this.UserDate_LBL.AutoSize = true;
            this.UserDate_LBL.Location = new System.Drawing.Point(214, 81);
            this.UserDate_LBL.Name = "UserDate_LBL";
            this.UserDate_LBL.Size = new System.Drawing.Size(118, 19);
            this.UserDate_LBL.TabIndex = 7;
            this.UserDate_LBL.Text = "Day/Month/Year";
            // 
            // InsertDate_BTN
            // 
            this.InsertDate_BTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertDate_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertDate_BTN.ForeColor = System.Drawing.Color.Black;
            this.InsertDate_BTN.Location = new System.Drawing.Point(18, 139);
            this.InsertDate_BTN.Name = "InsertDate_BTN";
            this.InsertDate_BTN.Size = new System.Drawing.Size(162, 33);
            this.InsertDate_BTN.TabIndex = 8;
            this.InsertDate_BTN.Text = "Insert Date";
            this.InsertDate_BTN.UseVisualStyleBackColor = false;
            this.InsertDate_BTN.Click += new System.EventHandler(this.InsertDate_BTN_Click);
            // 
            // ShamsiDate_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(404, 271);
            this.Controls.Add(this.InsertDate_BTN);
            this.Controls.Add(this.UserDate_LBL);
            this.Controls.Add(this.Day_TB);
            this.Controls.Add(this.Month_TB);
            this.Controls.Add(this.Year_TB);
            this.Controls.Add(this.Day_LBL);
            this.Controls.Add(this.Month_LBL);
            this.Controls.Add(this.Year_LBL);
            this.Controls.Add(this.Title_LBL);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "ShamsiDate_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shamsi Date Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.Label Year_LBL;
        private System.Windows.Forms.Label Month_LBL;
        private System.Windows.Forms.Label Day_LBL;
        private System.Windows.Forms.TextBox Year_TB;
        private System.Windows.Forms.TextBox Month_TB;
        private System.Windows.Forms.TextBox Day_TB;
        private System.Windows.Forms.Label UserDate_LBL;
        private System.Windows.Forms.Button InsertDate_BTN;
    }
}