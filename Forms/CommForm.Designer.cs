/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:05
 * 
 */
namespace CommTest.Forms
{
	partial class CommForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tBtimeout = new System.Windows.Forms.TextBox();
			this.cBportname = new System.Windows.Forms.ComboBox();
			this.cBparity = new System.Windows.Forms.ComboBox();
			this.cBstopbits = new System.Windows.Forms.ComboBox();
			this.cBdatabits = new System.Windows.Forms.ComboBox();
			this.cBbaudrate = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOpenport = new System.Windows.Forms.Button();
			this.textBoxLogdata = new System.Windows.Forms.TextBox();
			this.textBoxSend = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cBAutoSend = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxInterval = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxAutoClear = new System.Windows.Forms.CheckBox();
			this.checkBoxLoopBack = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableRule = new System.Windows.Forms.CheckBox();
			this.checkBoxShowdata = new System.Windows.Forms.CheckBox();
			this.checkBoxShowHex = new System.Windows.Forms.CheckBox();
			this.checkBoxSendHex = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.tBtimeout);
			this.groupBox1.Controls.Add(this.cBportname);
			this.groupBox1.Controls.Add(this.cBparity);
			this.groupBox1.Controls.Add(this.cBstopbits);
			this.groupBox1.Controls.Add(this.cBdatabits);
			this.groupBox1.Controls.Add(this.cBbaudrate);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonOpenport);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(161, 252);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Port Config";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(124, 173);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(19, 23);
			this.label11.TabIndex = 15;
			this.label11.Text = "ms";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tBtimeout
			// 
			this.tBtimeout.Location = new System.Drawing.Point(68, 175);
			this.tBtimeout.MaxLength = 6;
			this.tBtimeout.Name = "tBtimeout";
			this.tBtimeout.Size = new System.Drawing.Size(50, 21);
			this.tBtimeout.TabIndex = 14;
			this.tBtimeout.Text = "3000";
			// 
			// cBportname
			// 
			this.cBportname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBportname.FormattingEnabled = true;
			this.cBportname.Items.AddRange(new object[] {
									"COM1",
									"COM2",
									"COM3",
									"COM4",
									"COM5",
									"COM6",
									"COM7",
									"COM8",
									"COM9",
									"COM10",
									"COM11",
									"COM12",
									"COM13",
									"COM14",
									"COM15",
									"COM16",
									"COM17",
									"COM18",
									"COM19",
									"COM20"});
			this.cBportname.Location = new System.Drawing.Point(68, 20);
			this.cBportname.Name = "cBportname";
			this.cBportname.Size = new System.Drawing.Size(75, 20);
			this.cBportname.TabIndex = 13;
			// 
			// cBparity
			// 
			this.cBparity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBparity.FormattingEnabled = true;
			this.cBparity.Items.AddRange(new object[] {
									"None",
									"Odd",
									"Even",
									"Mark"});
			this.cBparity.Location = new System.Drawing.Point(68, 144);
			this.cBparity.Name = "cBparity";
			this.cBparity.Size = new System.Drawing.Size(75, 20);
			this.cBparity.TabIndex = 12;
			// 
			// cBstopbits
			// 
			this.cBstopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBstopbits.FormattingEnabled = true;
			this.cBstopbits.Items.AddRange(new object[] {
									"1",
									"1.5",
									"2"});
			this.cBstopbits.Location = new System.Drawing.Point(68, 113);
			this.cBstopbits.Name = "cBstopbits";
			this.cBstopbits.Size = new System.Drawing.Size(75, 20);
			this.cBstopbits.TabIndex = 11;
			// 
			// cBdatabits
			// 
			this.cBdatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBdatabits.FormattingEnabled = true;
			this.cBdatabits.Items.AddRange(new object[] {
									"8",
									"7",
									"6"});
			this.cBdatabits.Location = new System.Drawing.Point(68, 82);
			this.cBdatabits.Name = "cBdatabits";
			this.cBdatabits.Size = new System.Drawing.Size(75, 20);
			this.cBdatabits.TabIndex = 10;
			// 
			// cBbaudrate
			// 
			this.cBbaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBbaudrate.FormattingEnabled = true;
			this.cBbaudrate.Items.AddRange(new object[] {
									"2400",
									"4800",
									"9600",
									"19200",
									"38400",
									"76800",
									"115200"});
			this.cBbaudrate.Location = new System.Drawing.Point(68, 51);
			this.cBbaudrate.Name = "cBbaudrate";
			this.cBbaudrate.Size = new System.Drawing.Size(75, 20);
			this.cBbaudrate.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(9, 175);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Timeout";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(9, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Parity";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(9, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "StopBits";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "DataBits";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Baudrate";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "PortName";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonOpenport
			// 
			this.buttonOpenport.Location = new System.Drawing.Point(9, 212);
			this.buttonOpenport.Name = "buttonOpenport";
			this.buttonOpenport.Size = new System.Drawing.Size(136, 23);
			this.buttonOpenport.TabIndex = 0;
			this.buttonOpenport.Text = "Open Port";
			this.buttonOpenport.UseVisualStyleBackColor = true;
			this.buttonOpenport.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBoxLogdata
			// 
			this.textBoxLogdata.Location = new System.Drawing.Point(192, 41);
			this.textBoxLogdata.Multiline = true;
			this.textBoxLogdata.Name = "textBoxLogdata";
			this.textBoxLogdata.ReadOnly = true;
			this.textBoxLogdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLogdata.Size = new System.Drawing.Size(396, 238);
			this.textBoxLogdata.TabIndex = 1;
			// 
			// textBoxSend
			// 
			this.textBoxSend.Location = new System.Drawing.Point(192, 312);
			this.textBoxSend.Multiline = true;
			this.textBoxSend.Name = "textBoxSend";
			this.textBoxSend.Size = new System.Drawing.Size(322, 74);
			this.textBoxSend.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(192, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Log Data:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(192, 286);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Data to send:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cBAutoSend
			// 
			this.cBAutoSend.Location = new System.Drawing.Point(351, 285);
			this.cBAutoSend.Name = "cBAutoSend";
			this.cBAutoSend.Size = new System.Drawing.Size(72, 24);
			this.cBAutoSend.TabIndex = 5;
			this.cBAutoSend.Text = "AutoSend";
			this.cBAutoSend.UseVisualStyleBackColor = true;
			this.cBAutoSend.CheckedChanged += new System.EventHandler(this.CBAutoSendCheckedChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(450, 286);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 23);
			this.label9.TabIndex = 6;
			this.label9.Text = "Interval";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxInterval
			// 
			this.textBoxInterval.Location = new System.Drawing.Point(507, 287);
			this.textBoxInterval.Name = "textBoxInterval";
			this.textBoxInterval.Size = new System.Drawing.Size(48, 21);
			this.textBoxInterval.TabIndex = 7;
			this.textBoxInterval.Text = "500";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(561, 286);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(19, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "ms";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxAutoClear);
			this.groupBox2.Controls.Add(this.checkBoxLoopBack);
			this.groupBox2.Controls.Add(this.checkBoxEnableRule);
			this.groupBox2.Location = new System.Drawing.Point(13, 271);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(161, 115);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Rule Config";
			// 
			// checkBoxAutoClear
			// 
			this.checkBoxAutoClear.Checked = true;
			this.checkBoxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAutoClear.Location = new System.Drawing.Point(8, 87);
			this.checkBoxAutoClear.Name = "checkBoxAutoClear";
			this.checkBoxAutoClear.Size = new System.Drawing.Size(135, 24);
			this.checkBoxAutoClear.TabIndex = 4;
			this.checkBoxAutoClear.Text = "AutoClear";
			this.checkBoxAutoClear.UseVisualStyleBackColor = true;
			this.checkBoxAutoClear.CheckedChanged += new System.EventHandler(this.CheckBoxAutoClearCheckedChanged);
			// 
			// checkBoxLoopBack
			// 
			this.checkBoxLoopBack.Location = new System.Drawing.Point(8, 23);
			this.checkBoxLoopBack.Name = "checkBoxLoopBack";
			this.checkBoxLoopBack.Size = new System.Drawing.Size(135, 24);
			this.checkBoxLoopBack.TabIndex = 3;
			this.checkBoxLoopBack.Text = "LoopBack";
			this.checkBoxLoopBack.UseVisualStyleBackColor = true;
			this.checkBoxLoopBack.CheckedChanged += new System.EventHandler(this.CheckBoxLoopBackCheckedChanged);
			// 
			// checkBoxEnableRule
			// 
			this.checkBoxEnableRule.Location = new System.Drawing.Point(8, 54);
			this.checkBoxEnableRule.Name = "checkBoxEnableRule";
			this.checkBoxEnableRule.Size = new System.Drawing.Size(148, 24);
			this.checkBoxEnableRule.TabIndex = 0;
			this.checkBoxEnableRule.Text = "Enable reply rules";
			this.checkBoxEnableRule.UseVisualStyleBackColor = true;
			this.checkBoxEnableRule.CheckedChanged += new System.EventHandler(this.CheckBoxEnableRuleCheckedChanged);
			// 
			// checkBoxShowdata
			// 
			this.checkBoxShowdata.Checked = true;
			this.checkBoxShowdata.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShowdata.Location = new System.Drawing.Point(286, 15);
			this.checkBoxShowdata.Name = "checkBoxShowdata";
			this.checkBoxShowdata.Size = new System.Drawing.Size(77, 24);
			this.checkBoxShowdata.TabIndex = 3;
			this.checkBoxShowdata.Text = "Show log";
			this.checkBoxShowdata.UseVisualStyleBackColor = true;
			this.checkBoxShowdata.CheckedChanged += new System.EventHandler(this.CheckBoxShowdataCheckedChanged);
			// 
			// checkBoxShowHex
			// 
			this.checkBoxShowHex.Location = new System.Drawing.Point(376, 15);
			this.checkBoxShowHex.Name = "checkBoxShowHex";
			this.checkBoxShowHex.Size = new System.Drawing.Size(57, 24);
			this.checkBoxShowHex.TabIndex = 2;
			this.checkBoxShowHex.Text = "Hex";
			this.checkBoxShowHex.UseVisualStyleBackColor = true;
			this.checkBoxShowHex.CheckedChanged += new System.EventHandler(this.CheckBoxShowHexCheckedChanged);
			// 
			// checkBoxSendHex
			// 
			this.checkBoxSendHex.Location = new System.Drawing.Point(286, 285);
			this.checkBoxSendHex.Name = "checkBoxSendHex";
			this.checkBoxSendHex.Size = new System.Drawing.Size(48, 24);
			this.checkBoxSendHex.TabIndex = 1;
			this.checkBoxSendHex.Text = "Hex";
			this.checkBoxSendHex.UseVisualStyleBackColor = true;
			this.checkBoxSendHex.CheckedChanged += new System.EventHandler(this.CheckBoxSendHexCheckedChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(520, 312);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 74);
			this.button2.TabIndex = 0;
			this.button2.Text = "Send";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(520, 16);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(68, 23);
			this.buttonClear.TabIndex = 10;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// CommForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.checkBoxSendHex);
			this.Controls.Add(this.checkBoxShowdata);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.checkBoxShowHex);
			this.Controls.Add(this.textBoxInterval);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cBAutoSend);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxSend);
			this.Controls.Add(this.textBoxLogdata);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CommForm";
			this.Text = "CommForm";
			this.Load += new System.EventHandler(this.CommFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBoxAutoClear;
		private System.Windows.Forms.CheckBox checkBoxLoopBack;
		private System.Windows.Forms.CheckBox checkBoxEnableRule;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cBdatabits;
		private System.Windows.Forms.ComboBox cBstopbits;
		private System.Windows.Forms.ComboBox cBparity;
		private System.Windows.Forms.ComboBox cBportname;
		private System.Windows.Forms.TextBox tBtimeout;
		private System.Windows.Forms.CheckBox checkBoxShowdata;
		private System.Windows.Forms.CheckBox checkBoxShowHex;
		private System.Windows.Forms.ComboBox cBbaudrate;
		private System.Windows.Forms.CheckBox checkBoxSendHex;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxInterval;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox cBAutoSend;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxSend;
		private System.Windows.Forms.TextBox textBoxLogdata;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonOpenport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		
	}
}
