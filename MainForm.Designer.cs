/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:06
 * 
 */
namespace CommTest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripBtnComm = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnSocket = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnPcap = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnRule = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnVSPD = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnTopMost = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(720, 480);
			this.panel1.TabIndex = 1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripBtnComm,
									this.toolStripSeparator1,
									this.toolStripBtnSocket,
									this.toolStripSeparator4,
									this.toolStripBtnPcap,
									this.toolStripSeparator5,
									this.toolStripBtnRule,
									this.toolStripSeparator2,
									this.toolStripBtnVSPD,
									this.toolStripSeparator3,
									this.toolStripBtnTopMost,
									this.toolStripSeparator,
									this.helpToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(715, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripBtnComm
			// 
			this.toolStripBtnComm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnComm.Image")));
			this.toolStripBtnComm.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnComm.Name = "toolStripBtnComm";
			this.toolStripBtnComm.Size = new System.Drawing.Size(84, 22);
			this.toolStripBtnComm.Text = "SerialPort";
			this.toolStripBtnComm.Click += new System.EventHandler(this.ToolStripBtnCommClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtnSocket
			// 
			this.toolStripBtnSocket.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSocket.Image")));
			this.toolStripBtnSocket.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnSocket.Name = "toolStripBtnSocket";
			this.toolStripBtnSocket.Size = new System.Drawing.Size(100, 22);
			this.toolStripBtnSocket.Text = "Socket(Real)";
			this.toolStripBtnSocket.Click += new System.EventHandler(this.ToolStripBtnSocketClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtnPcap
			// 
			this.toolStripBtnPcap.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPcap.Image")));
			this.toolStripBtnPcap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnPcap.Name = "toolStripBtnPcap";
			this.toolStripBtnPcap.Size = new System.Drawing.Size(103, 22);
			this.toolStripBtnPcap.Text = "Socket(Pcap)";
			this.toolStripBtnPcap.Click += new System.EventHandler(this.ToolStripBtnPcapClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtnRule
			// 
			this.toolStripBtnRule.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRule.Image")));
			this.toolStripBtnRule.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnRule.Name = "toolStripBtnRule";
			this.toolStripBtnRule.Size = new System.Drawing.Size(79, 22);
			this.toolStripBtnRule.Text = "Rule Edit";
			this.toolStripBtnRule.Click += new System.EventHandler(this.ToolStripBtnRuleClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtnVSPD
			// 
			this.toolStripBtnVSPD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnVSPD.Image")));
			this.toolStripBtnVSPD.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnVSPD.Name = "toolStripBtnVSPD";
			this.toolStripBtnVSPD.Size = new System.Drawing.Size(104, 22);
			this.toolStripBtnVSPD.Text = "Port Manage";
			this.toolStripBtnVSPD.Click += new System.EventHandler(this.ToolStripBtnVSPDClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtnTopMost
			// 
			this.toolStripBtnTopMost.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnTopMost.Image")));
			this.toolStripBtnTopMost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnTopMost.Name = "toolStripBtnTopMost";
			this.toolStripBtnTopMost.Size = new System.Drawing.Size(81, 22);
			this.toolStripBtnTopMost.Text = "TopMost";
			this.toolStripBtnTopMost.Click += new System.EventHandler(this.ToolStripBtnTopMostClick);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "He&lp";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 502);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CommTest";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton toolStripBtnPcap;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripBtnSocket;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton toolStripBtnTopMost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripBtnVSPD;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripBtnRule;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripBtnComm;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Panel panel1;
		
	}
}
