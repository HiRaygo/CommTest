/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:06
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using CommTest.Common;
using CommTest.Forms;

namespace CommTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		RuleForm rForm;
		CommForm cForm;
		VSPDForm vForm;
		SocketForm sForm;
		PcapForm pForm;
		int formtype;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//rForm = new RuleForm();
			cForm = new CommForm();
			//vForm = new VSPDForm();
		}
		
		private void SwitchForm(Form form)
		{
			panel1.Controls.Clear();	//移除所有控件
			form.TopLevel = false;	  //设置为非顶级窗体
			form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
			form.Dock = System.Windows.Forms.DockStyle.Fill;				  //设置样式是否填充整个panel
			panel1.Controls.Add(form);	//添加窗体
			form.Show();	
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{			
			SwitchForm(cForm);
			formtype = 0;
			toolStripBtnComm.Checked = true;
		}
		
		void ToolStripBtnCommClick(object sender, EventArgs e)
		{
			if(formtype != 0)
			{
				SwitchForm(cForm);
				formtype = 0;
				toolStripBtnComm.Checked = true;
				toolStripBtnRule.Checked = false;
				toolStripBtnVSPD.Checked = false;
				toolStripBtnSocket.Checked = false;
				toolStripBtnPcap.Checked = false;
			}
		}
		
		void ToolStripBtnRuleClick(object sender, EventArgs e)
		{
			if(formtype != 1)
			{
				if(rForm ==null)
					rForm = new RuleForm();
				SwitchForm(rForm);
				formtype = 1;
				toolStripBtnComm.Checked = false;
				toolStripBtnRule.Checked = true;
				toolStripBtnVSPD.Checked = false;
				toolStripBtnSocket.Checked = false;
				toolStripBtnPcap.Checked = false;
			}
		}
		
		void ToolStripBtnVSPDClick(object sender, EventArgs e)
		{
			if(formtype != 2)
			{
				if(vForm == null)
					vForm = new VSPDForm();
				SwitchForm(vForm);
				formtype = 2;
				toolStripBtnComm.Checked = false;
				toolStripBtnRule.Checked = false;
				toolStripBtnVSPD.Checked = true;
				toolStripBtnSocket.Checked = false;
				toolStripBtnPcap.Checked = false;
			}		
		}
		
		void ToolStripBtnTopMostClick(object sender, EventArgs e)
		{
			if(this.TopMost)
			{
				this.TopMost = false;
				toolStripBtnTopMost.Checked = false;
			}
			else
			{
				this.TopMost = true;
				toolStripBtnTopMost.Checked = true;
			}
		}
		
		void ToolStripBtnSocketClick(object sender, EventArgs e)
		{
			if(formtype != 3)
			{
				if(sForm == null)
					sForm = new SocketForm();
				SwitchForm(sForm);
				formtype = 3;
				toolStripBtnComm.Checked = false;
				toolStripBtnRule.Checked = false;
				toolStripBtnVSPD.Checked = false;
				toolStripBtnSocket.Checked = true;
				toolStripBtnPcap.Checked = false;
			}
		}
		
		void ToolStripBtnPcapClick(object sender, EventArgs e)
		{
			if(formtype != 4)
			{
				if(pForm == null)
					pForm = new PcapForm();
				SwitchForm(pForm);
				formtype = 4;
				toolStripBtnComm.Checked = false;
				toolStripBtnRule.Checked = false;
				toolStripBtnVSPD.Checked = false;
				toolStripBtnSocket.Checked = false;
				toolStripBtnPcap.Checked = true;
			}
		}
	}
}
