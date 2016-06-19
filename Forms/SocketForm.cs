/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:05
 * 
 */
using System;
using System.Collections;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using CommTest.Common;

namespace CommTest.Forms
{
	/// <summary>
	/// Description of SocketForm.
	/// </summary>
	public partial class SocketForm : Form
	{
		Socket serverSocket;
		Hashtable AllClients;
		bool isServering;
		const int MAXCLIENTS = 10;
		const int RECEIVEBUFFERSIZE = 256;
		
		bool isShowHex;
		bool isSendHex;
		bool isLogData;
		bool isEnableRule;
		bool isLoopBack;
		bool isAutoSend;
		bool isAutoClear;
		int iii = 0;
		
		delegate void LogDataHandler(string str, int type);
		LogDataHandler ld;
		
		public SocketForm()
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
			isEnableRule = true;
			isLoopBack = false;
			isAutoSend = false;
			isAutoClear = true;
			
			isServering = false;
			AllClients = new Hashtable();
			
			ld = new LogDataHandler(LogData);
		}
		
		/// <summary>
		/// work when form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void SocketFormLoad(object sender, EventArgs e)
		{
			comboBoxTCP1.SelectedIndex = 0;
			comboBoxTCP2.SelectedIndex = 0;
			if(!GetLocalIP()){
				MessageBox.Show("Get IP fail.");
				return;}
			comboBoxServerIP.SelectedIndex = 0;
		}
		
		/// <summary>
		/// get the local ips
		/// </summary>
		/// <returns></returns>
		public bool GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName();
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                    	comboBoxServerIP.Items.Add(IpEntry.AddressList[i].ToString());
                    }
                }
                comboBoxServerIP.Items.Add("127.0.0.1");
            }
            catch
            {
                return false;
            }
            return true;
        }
		
		/// <summary>
		/// click the open port button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonStartServerClick(object sender, EventArgs e)
		{
			if(isServering)
			{
				serverSocket.Close();
				isServering = false;
				buttonStartServer.Text = "Start Server";
				LogData("TCP Server stop.", 0);
			}
			else
			{
				string ipstr = comboBoxServerIP.Text;
				string portstr = textBoxServerPort.Text;
				if((ipstr.Length ==0) ||(portstr.Length ==0))
				{
					LogData("Please input IP and Port.", 0);
					return;
				}
				try{
					
					int port = int.Parse(portstr);
					StartServer(ipstr, port);
				}
				catch{
					LogData("Start TCP server falied.", 0);
					return;
				}
				isServering = true;
				buttonStartServer.Text = "Stop Server";
				LogData("TCP Server start.", 0);
			}
		}
		
		
		private void StartServer(string ip, int port)
		{
			serverSocket = new Socket(SocketType.Stream,ProtocolType.Tcp);
			IPAddress ipa = IPAddress.Parse(ip);
			IPEndPoint ipe= new IPEndPoint(ipa,port);
			serverSocket.Bind(ipe);
			serverSocket.Listen(MAXCLIENTS);
			Thread lj = new Thread(new ThreadStart(WaitForConnect));
			lj.IsBackground = true;
			lj.Start();
		}
		
		private void WaitForConnect()
		{
			while(isServering)
			{
				Thread.Sleep(10);
				try{
					Socket client = serverSocket.Accept();
					object oj = client;
					Thread ml = new Thread(new ParameterizedThreadStart(ReceiveLoop));
					ml.IsBackground = true;
					ml.Start(oj);
				}
				catch{
					if(serverSocket != null)
						serverSocket.Close();
					isServering = false;
				}
			}
		}
		/// <summary>
		/// Message Loop
		/// </summary>
		/// <param name="cl"></param>
		private void ReceiveLoop(object cl)
		{
			Socket client = cl as Socket;
			if(client == null)
				return;
			string clientName = client.RemoteEndPoint.ToString();
			AllClients.Add(clientName,client);
			LogData(clientName +" is connected.", 0);
			byte[] rbytes = new byte[RECEIVEBUFFERSIZE];
			int count;
			while(true)
			{
				count =0;
				try{
					count = client.Receive(rbytes);
					if(count>0)
					{
						string restr = Encoding.Default.GetString(rbytes);
						LogData(clientName + " received: "+ restr, 2);
						byte[] sbytes = rbytes;
						client.Send(sbytes, sbytes.Length, SocketFlags.None);
						string sestr = Encoding.Default.GetString(sbytes);
						LogData(clientName + " send: "+ sestr, 1);
					}
				}
				catch{
					break;
				}
			}
			AllClients.Remove(clientName);
			LogData(clientName +" is disconnected.", 0);
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
			string rstring = textBoxSend.Text;
			if(string.IsNullOrEmpty(rstring))
				return;
			try{
				if(isSendHex)
					textBoxSend.Text = HexString.Bytes2HexString(HexString.AsciiString2Bytes(rstring));
				else
					textBoxSend.Text = HexString.Bytes2AsciiString(HexString.HexString2Bytes(rstring));
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
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
		
		void ButtonConnectClick(object sender, EventArgs e)
		{
			
		}
		
		void ButtonSendClick(object sender, EventArgs e)
		{
			
		}
	}
}
