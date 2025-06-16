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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevDashBoard_FRM));
			this.Header_PNL = new System.Windows.Forms.Panel();
			this.TabTools_TLB = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.TabTools_TLB.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header_PNL
			// 
			this.Header_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Header_PNL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Header_PNL.BackColor = System.Drawing.Color.Navy;
			this.Header_PNL.Location = new System.Drawing.Point(19, 7);
			this.Header_PNL.Name = "Header_PNL";
			this.Header_PNL.Size = new System.Drawing.Size(1146, 50);
			this.Header_PNL.TabIndex = 0;
			// 
			// TabTools_TLB
			// 
			this.TabTools_TLB.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.TabTools_TLB.Controls.Add(this.tabPage1);
			this.TabTools_TLB.Controls.Add(this.tabPage2);
			this.TabTools_TLB.Controls.Add(this.tabPage3);
			this.TabTools_TLB.Controls.Add(this.tabPage4);
			this.TabTools_TLB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TabTools_TLB.Location = new System.Drawing.Point(19, 63);
			this.TabTools_TLB.Multiline = true;
			this.TabTools_TLB.Name = "TabTools_TLB";
			this.TabTools_TLB.SelectedIndex = 0;
			this.TabTools_TLB.Size = new System.Drawing.Size(1143, 693);
			this.TabTools_TLB.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(30, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1109, 685);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Converter";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(30, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1109, 685);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Formatter";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.Color.Navy;
			this.panel1.Location = new System.Drawing.Point(16, 762);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1146, 50);
			this.panel1.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(30, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1109, 685);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Measurement";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(30, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1109, 685);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Text";
			this.tabPage4.UseVisualStyleBackColor = true;
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
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "DevDashBoard_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tool Box One";
			this.TabTools_TLB.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Header_PNL;
		private System.Windows.Forms.TabControl TabTools_TLB;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
	}
}

