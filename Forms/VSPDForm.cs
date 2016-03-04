/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/23
 * Time: 11:09
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using CommTest.Common;

namespace CommTest.Forms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class VSPDForm : Form
	{
		public VSPDForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			UpdatePortList();
		}
		
		void BtnCreateClick(object sender, EventArgs e)
		{
			string com1 = textBox1.Text;
			string com2 = textBox2.Text;
			if((com1.StartsWith("COM"))&&(com2.StartsWith("COM")))
			{
				if(VSPD.CreatePair(com1, com2))
				{
					UpdatePortList();
				}
				else
				{
					MessageBox.Show("Create port failed.");
				}
			}
			else
			{
				MessageBox.Show("Port must be named like COM#");
			}
		}
		
		void BtnDeletePairClick(object sender, EventArgs e)
		{
			var comx = treeView1.SelectedNode;
			if(comx != null)
			{
				string comxt = comx.Text;
				if(comxt.StartsWith("COM"))
				{
					string com1 = comxt.Split(new char[]{'+'})[0];
					if(VSPD.DeletePair(com1))
					{
						UpdatePortList();
					}
					else
					{
						MessageBox.Show("Delete port failed.");
					}
				}
			}		
		}
		
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}
		
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}
		
//		private void UpdatePorts()
//		{
//			
//			VSPD._VSBUS_QUERY Query = new VSPD._VSBUS_QUERY();
//			int iSize = Marshal.SizeOf(Query);//获取结构体占用空间大小
//			IntPtr iIntptr= Marshal.AllocHGlobal(iSize);//声明一个同样大小的空间
//			Marshal.StructureToPtr(Query, iIntptr, true);//将结构体放到这个空间中
//			
//			long oSize = 32;
//			VSPD._PORT_INFORMATION oPortInfo = new VSPD._PORT_INFORMATION();
//			int pSize = Marshal.SizeOf(oPortInfo);//获取结构体占用空间大小
//			IntPtr oIntptr= Marshal.AllocHGlobal(pSize);//声明一个同样大小的空间
//			Marshal.StructureToPtr(oPortInfo, oIntptr, true);//将结构体放到这个空间中
//
//			bool sf = VSPD.QueryBus(iIntptr, iSize, oIntptr, oSize);
//			if(!sf)
//				return;
//			
//			VSPD._PORT_INFORMATION portInfo = (VSPD._PORT_INFORMATION)Marshal.PtrToStructure(oIntptr,typeof(VSPD._PORT_INFORMATION));
//			
//		}
		
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			if(e.Action == TreeViewAction.ByMouse)
			{
				if(e.Node.Text.StartsWith("COM"))
				{
					textBox3.Text = e.Node.Text;
				}
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(VSPD.DeleteAll())
			{				
				UpdatePortList();
			}
			else
				MessageBox.Show("Delete ports failed.");
		}
		
		///Update the port treeview list		
		void UpdatePortList()
		{
			Thread.Sleep(1000);
			treeView1.Nodes.Clear();
			TreeNode rootnode = new TreeNode("Serial Ports");
			foreach(string portname in SerialPort.GetPortNames())
			{
				rootnode.Nodes.Add(portname);
			}
			treeView1.Nodes.Add(rootnode);
			treeView1.ExpandAll();
		}
	}
}
