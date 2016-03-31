/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:05
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using CommTest.Common;
using System.IO.Ports;

namespace CommTest.Forms
{
	/// <summary>
	/// Description of CommForm.
	/// </summary>
	public partial class CommForm : Form
	{
		SerialPort port = null;
		bool isShowHex;
		bool isSendHex;
		bool isLogData;
		bool isEnableRule;
		bool isLoopBack;
		bool isAutoSend;
		bool isAutoClear;
		bool ReceiveEventFlag = false;
		int iii = 0;
		
		delegate void LogDataHandler(string str, int type);
		LogDataHandler ld;
		
		public CommForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			isShowHex = false;
			isSendHex = false;
			isLogData = true;
			isEnableRule = false;
			isLoopBack = false;
			isAutoSend = false;
			isAutoClear = true;
			ld = new LogDataHandler(LogData);
		}
		
		/// <summary>
		/// click the open port button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{
			if(port!= null)
			{
				if(port.IsOpen)
				{
					try{
						port.Close();
					}
					catch(Exception ee)
					{
						buttonOpenport.Text = "Close Port";
						LogData(ee.Message, 0);
						return;
					}
					buttonOpenport.Text = "Open Port";
					LogData(port.PortName +" is closed.", 0);
					return;
				}
			}
			
			string portname = cBportname.Text;
			int baudrate = int.Parse(cBbaudrate.Text);
			int databits = int.Parse(cBdatabits.Text);
			string stopbits = cBstopbits.Text;
			string parity = cBparity.Text;
			int timeout = int.Parse(tBtimeout.Text);
						
			try{
				OpenPort(portname,baudrate, databits, stopbits, parity, timeout);
			}
			catch(Exception ex){
				buttonOpenport.Text = "Open Port";
				LogData(ex.Message, 0);
				return;
			}
			buttonOpenport.Text = "Close Port";
			LogData(portname + " is opened.", 0);
		}
		
		/// <summary>
		/// open the port and config paras
		/// </summary>
		/// <param name="sPortName"></param>
		/// <param name="baudrate"></param>
		/// <param name="databits"></param>
		/// <param name="stopbits"></param>
		/// <param name="parity"></param>
		/// <param name="timeout"></param>
		void OpenPort(string sPortName, int baudrate, int databits, string stopbits, string parity, int timeout)
        {
        	StopBits sb;
        	if(stopbits =="2")
        		sb = StopBits.Two;
        	else if(stopbits == "1.5")
        		sb = StopBits.OnePointFive;
        	else
        		sb = StopBits.One;
        	
        	Parity prt;
        	if(parity == "Even")
        		prt = Parity.Even;
        	else if(parity == "Odd")
        		prt = Parity.Odd;
        	else if(parity =="Mark")
        		prt = Parity.Mark;
        	else
        		prt = Parity.None;
        	
            port = new SerialPort(sPortName, baudrate, prt, databits, sb);
            port.DataBits = databits;
            port.RtsEnable = true;
            port.ReadTimeout = timeout;
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
        }
		
		/// <summary>
		/// event when port received data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
			int len = port.BytesToRead;
			if(len <= 0)
				return;
			
			byte[] rcvdata = new byte[len];
			int rlen = port.Read(rcvdata, 0, len);
			port.DiscardInBuffer();	
			if(rlen ==0)
				return;
			
			if(isShowHex)
			{
				LogData(HexString.Bytes2HexString(rcvdata), 2);
			}
			else
			{
				LogData(HexString.Bytes2AsciiString(rcvdata), 2);
			}
			
			if(isEnableRule)
			{
				byte[][] rspdata;
				MatchedInfo minfo;
				if(RuleHelper.GetMatchedMesage(rcvdata, out rspdata, out minfo))
				{
					for(int i=0; i<minfo.NofMsg; i++)
					{
						System.Threading.Thread.Sleep(minfo.Delays[i]);
						port.Write(rspdata[i], 0, rspdata[i].Length);
						if(isShowHex)
						{
							LogData(HexString.Bytes2HexString(rspdata[i]), 1);
						}
						else
						{
							LogData(HexString.Bytes2AsciiString(rspdata[i]), 1);
						}
					}
				}
			}
			else
			{
				if(isLoopBack)
				{
					port.Write(rcvdata, 0, rcvdata.Length);
					if(isShowHex)
					{
						LogData(HexString.Bytes2HexString(rcvdata), 1);
					}
					else
					{
						LogData(HexString.Bytes2AsciiString(rcvdata), 1);
					}
				}
			}
		}
		/// <summary>
		/// work when form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void CommFormLoad(object sender, EventArgs e)
		{
			cBportname.SelectedIndex = 0;
			cBbaudrate.SelectedIndex = 2;
			cBdatabits.SelectedIndex = 0;
			cBparity.SelectedIndex =0;
			cBstopbits.SelectedIndex =0;
		}
		
		/// <summary>
		/// click the send button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button2Click(object sender, EventArgs e)
		{			
			PortSendData();
		}
		
		/// <summary>
		/// send data
		/// </summary>
		void PortSendData()
		{
			if(port == null)
				return;
			if(!(port.IsOpen))
				return;
			string senddata = textBoxSend.Text;
			if(string.IsNullOrEmpty(senddata))
				return;
			if(ReceiveEventFlag)
				return;
			if(isSendHex)
			{
				byte[] data = HexString.HexString2Bytes(senddata);
				port.Write(data,0,data.Length);
				if(isShowHex)
				{
					LogData(senddata, 1);
				}
				else
				{
					LogData(HexString.Bytes2AsciiString(data), 1);
				}
			}
			else
			{
				port.Write(senddata);
				if(isShowHex)
				{
					byte[] data = HexString.AsciiString2Bytes(senddata);
					LogData(HexString.Bytes2HexString(data), 1);
				}
				else
				{					
					LogData(senddata, 1);
				}
			}			
		}
		
		/// <summary>
		/// show the log in the textbox
		/// </summary>
		/// <param name="str"></param>
		/// <param name="type"></param>
		void LogData(string str, int type)
		{
			if(!isLogData)
				return;
			
			if(textBoxLogdata.InvokeRequired)
			{				
				this.Invoke(ld, new object[]{str, type});
			}
			else
			{
				//Auto clear
				if(isAutoClear)
				{
					iii++;
					if(iii > 50)
					{
						iii = 0;
						if(textBoxLogdata.TextLength > 10000)
							textBoxLogdata.Clear();						
					}
				}
				//Log data
				if(type == 1)
					textBoxLogdata.AppendText("Send: "+ str + "\n");
				else if(type ==2)
					textBoxLogdata.AppendText("Recv: "+ str + "\n");
				else
					textBoxLogdata.AppendText("Info: "+ str + "\n");
			}			
		}
		
      
        /// <summary>
        /// send command
        /// </summary>
        /// <param name="SendData">cmd to be send</param>
        /// <param name="ReceiveData">data received</param>
        /// <param name="Overtime">timeout</param>
        /// <returns></returns>
        int SendCommand(byte[] SendData, ref  byte[] ReceiveData,int Overtime)
        {

            if(port.IsOpen)
            {
                ReceiveEventFlag = true;        //关闭接收事件
                port.DiscardInBuffer();         //清空接收缓冲区                 
                port.Write(SendData, 0, SendData.Length);
                int num=0,ret=0;
                while (num++ < Overtime)
                {
                    if(port.BytesToRead >= ReceiveData.Length) break;
                    System.Threading.Thread.Sleep(1); 
                }
                if (port.BytesToRead >= ReceiveData.Length) 
                    ret = port.Read(ReceiveData, 0, ReceiveData.Length);
                ReceiveEventFlag = false;       //打开事件
                return ret;
            }
            return -1;
        }
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			this.textBoxLogdata.Clear();
		}
		
		void CheckBoxShowHexCheckedChanged(object sender, EventArgs e)
		{
			isShowHex = checkBoxShowHex.Checked;			
		}
		
		void CheckBoxShowdataCheckedChanged(object sender, EventArgs e)
		{
			isLogData = checkBoxShowdata.Checked;
		}
		
		void CheckBoxSendHexCheckedChanged(object sender, EventArgs e)
		{
			isSendHex = checkBoxSendHex.Checked;			
		}
		
		void CBAutoSendCheckedChanged(object sender, EventArgs e)
		{
			isAutoSend = cBAutoSend.Checked;			
		}
		
		void CheckBoxEnableRuleCheckedChanged(object sender, EventArgs e)
		{
			isEnableRule = checkBoxEnableRule.Checked;
			if(isEnableRule)
			{
				checkBoxLoopBack.Checked = false;
			}
		}
		
		
		void ButtonLoadRulesClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "XML Document(*.xml)|*.xml";
			ofd.Multiselect = false;
			ofd.ValidateNames = true;
			if(ofd.ShowDialog() == DialogResult.OK)
            {
				try{
					RuleHelper.ImportRulesFromXml(ofd.FileName);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
		}
		
		void CheckBoxLoopBackCheckedChanged(object sender, EventArgs e)
		{
			isLoopBack = checkBoxLoopBack.Checked;
			if(isLoopBack)
			{
				checkBoxEnableRule.Checked = false;
			}
		}
		
		void CheckBoxAutoClearCheckedChanged(object sender, EventArgs e)
		{
			isAutoClear = checkBoxAutoClear.Checked;
		}
	}
}
