namespace DevToolBoxOne
{
	partial class DevDashBoard_FRM
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevDashBoard_FRM));
			this.Header_PNL = new System.Windows.Forms.Panel();
			this.TabTools_TLB = new System.Windows.Forms.TabControl();
			this.Converter_TB0 = new System.Windows.Forms.TabPage();
			this.ShamsiDate_BTN = new System.Windows.Forms.Button();
			this.Formatter_TB1 = new System.Windows.Forms.TabPage();
			this.Measurement_TB2 = new System.Windows.Forms.TabPage();
			this.Text_TB3 = new System.Windows.Forms.TabPage();
			this.CLICommand_TB4 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ShamsiDateButton_TOTP = new System.Windows.Forms.ToolTip(this.components);
			this.TabTools_TLB.SuspendLayout();
			this.Converter_TB0.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header_PNL
			// 
			this.Header_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Header_PNL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Header_PNL.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Header_PNL.Location = new System.Drawing.Point(19, 7);
			this.Header_PNL.Name = "Header_PNL";
			this.Header_PNL.Size = new System.Drawing.Size(1146, 50);
			this.Header_PNL.TabIndex = 0;
			// 
			// TabTools_TLB
			// 
			this.TabTools_TLB.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.TabTools_TLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabTools_TLB.Controls.Add(this.Converter_TB0);
			this.TabTools_TLB.Controls.Add(this.Formatter_TB1);
			this.TabTools_TLB.Controls.Add(this.Measurement_TB2);
			this.TabTools_TLB.Controls.Add(this.Text_TB3);
			this.TabTools_TLB.Controls.Add(this.CLICommand_TB4);
			this.TabTools_TLB.Cursor = System.Windows.Forms.Cursors.Default;
			this.TabTools_TLB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TabTools_TLB.Location = new System.Drawing.Point(19, 63);
			this.TabTools_TLB.Multiline = true;
			this.TabTools_TLB.Name = "TabTools_TLB";
			this.TabTools_TLB.SelectedIndex = 0;
			this.TabTools_TLB.ShowToolTips = true;
			this.TabTools_TLB.Size = new System.Drawing.Size(1143, 693);
			this.TabTools_TLB.TabIndex = 1;
			// 
			// Converter_TB0
			// 
			this.Converter_TB0.Controls.Add(this.ShamsiDate_BTN);
			this.Converter_TB0.Cursor = System.Windows.Forms.Cursors.Default;
			this.Converter_TB0.Location = new System.Drawing.Point(30, 4);
			this.Converter_TB0.Name = "Converter_TB0";
			this.Converter_TB0.Padding = new System.Windows.Forms.Padding(3);
			this.Converter_TB0.Size = new System.Drawing.Size(1109, 685);
			this.Converter_TB0.TabIndex = 0;
			this.Converter_TB0.Text = "Converter";
			this.Converter_TB0.UseVisualStyleBackColor = true;
			// 
			// ShamsiDate_BTN
			// 
			this.ShamsiDate_BTN.BackColor = System.Drawing.Color.White;
			this.ShamsiDate_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ShamsiDate_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ShamsiDate_BTN.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.ShamsiDate_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ShamsiDate_BTN.Location = new System.Drawing.Point(30, 24);
			this.ShamsiDate_BTN.Name = "ShamsiDate_BTN";
			this.ShamsiDate_BTN.Size = new System.Drawing.Size(150, 150);
			this.ShamsiDate_BTN.TabIndex = 0;
			this.ShamsiDate_BTN.Text = "Shamsi Date";
			this.ShamsiDateButton_TOTP.SetToolTip(this.ShamsiDate_BTN, "Converting solar date to Gregorian date and vice versa");
			this.ShamsiDate_BTN.UseVisualStyleBackColor = false;
			this.ShamsiDate_BTN.Click += new System.EventHandler(this.ShamsiDate_BTN_Click);
			// 
			// Formatter_TB1
			// 
			this.Formatter_TB1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Formatter_TB1.Location = new System.Drawing.Point(30, 4);
			this.Formatter_TB1.Name = "Formatter_TB1";
			this.Formatter_TB1.Padding = new System.Windows.Forms.Padding(3);
			this.Formatter_TB1.Size = new System.Drawing.Size(1109, 685);
			this.Formatter_TB1.TabIndex = 1;
			this.Formatter_TB1.Text = "Formatter";
			this.Formatter_TB1.UseVisualStyleBackColor = true;
			// 
			// Measurement_TB2
			// 
			this.Measurement_TB2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Measurement_TB2.Location = new System.Drawing.Point(30, 4);
			this.Measurement_TB2.Name = "Measurement_TB2";
			this.Measurement_TB2.Size = new System.Drawing.Size(1109, 685);
			this.Measurement_TB2.TabIndex = 2;
			this.Measurement_TB2.Text = "Measurement";
			this.Measurement_TB2.UseVisualStyleBackColor = true;
			// 
			// Text_TB3
			// 
			this.Text_TB3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Text_TB3.Location = new System.Drawing.Point(30, 4);
			this.Text_TB3.Name = "Text_TB3";
			this.Text_TB3.Size = new System.Drawing.Size(1109, 685);
			this.Text_TB3.TabIndex = 3;
			this.Text_TB3.Text = "Text";
			this.Text_TB3.UseVisualStyleBackColor = true;
			// 
			// CLICommand_TB4
			// 
			this.CLICommand_TB4.Cursor = System.Windows.Forms.Cursors.Default;
			this.CLICommand_TB4.Location = new System.Drawing.Point(30, 4);
			this.CLICommand_TB4.Name = "CLICommand_TB4";
			this.CLICommand_TB4.Size = new System.Drawing.Size(1109, 685);
			this.CLICommand_TB4.TabIndex = 4;
			this.CLICommand_TB4.Text = "CLI Command";
			this.CLICommand_TB4.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Location = new System.Drawing.Point(16, 762);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1146, 50);
			this.panel1.TabIndex = 1;
			// 
			// DevDashBoard_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1180, 817);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TabTools_TLB);
			this.Controls.Add(this.Header_PNL);
			this.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "DevDashBoard_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tool Box One";
			this.TabTools_TLB.ResumeLayout(false);
			this.Converter_TB0.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Header_PNL;
		private System.Windows.Forms.TabControl TabTools_TLB;
		private System.Windows.Forms.TabPage Converter_TB0;
		private System.Windows.Forms.TabPage Formatter_TB1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage Measurement_TB2;
		private System.Windows.Forms.TabPage Text_TB3;
		private System.Windows.Forms.TabPage CLICommand_TB4;
		private System.Windows.Forms.Button ShamsiDate_BTN;
		private System.Windows.Forms.ToolTip ShamsiDateButton_TOTP;
	}
}

