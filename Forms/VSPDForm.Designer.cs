/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/23
 * Time: 11:09
 * 
 */
namespace CommTest.Forms
{
	partial class VSPDForm
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Serial Ports");
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnDeletePair = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(194, 105);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(96, 49);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Add Pair";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// btnDeletePair
			// 
			this.btnDeletePair.Location = new System.Drawing.Point(194, 195);
			this.btnDeletePair.Name = "btnDeletePair";
			this.btnDeletePair.Size = new System.Drawing.Size(96, 49);
			this.btnDeletePair.TabIndex = 1;
			this.btnDeletePair.Text = "Delete Pair";
			this.btnDeletePair.UseVisualStyleBackColor = true;
			this.btnDeletePair.Click += new System.EventHandler(this.BtnDeletePairClick);
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(26, 26);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node0";
			treeNode1.Text = "Serial Ports";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
									treeNode1});
			this.treeView1.Size = new System.Drawing.Size(191, 353);
			this.treeView1.TabIndex = 2;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
			// 
			// textBox1
			// 
			this.textBox1.AllowDrop = true;
			this.textBox1.Location = new System.Drawing.Point(110, 105);
			this.textBox1.MaxLength = 6;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(54, 21);
			this.textBox1.TabIndex = 3;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "COM10";
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.AllowDrop = true;
			this.textBox2.Location = new System.Drawing.Point(110, 133);
			this.textBox2.MaxLength = 6;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(54, 21);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "COM11";
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.btnDeletePair);
			this.groupBox1.Controls.Add(this.btnCreate);
			this.groupBox1.Location = new System.Drawing.Point(253, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 353);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Port Manage";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(240, 21);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(50, 37);
			this.button2.TabIndex = 17;
			this.button2.Text = "*";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 74);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(304, 23);
			this.label10.TabIndex = 16;
			this.label10.Text = ".................................................";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(17, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(217, 56);
			this.label8.TabIndex = 15;
			this.label8.Text = "Please click the right button to install virtual port driver when you run the app" +
			" in the first time, it will spend about 30 seconds.";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(194, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 49);
			this.button1.TabIndex = 14;
			this.button1.Text = "Delete All";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(17, 286);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(154, 43);
			this.label7.TabIndex = 13;
			this.label7.Text = "All virtual port will be removed. Make sure all ports are closed.";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(304, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = ".................................................";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(304, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = ".................................................";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Second port:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(17, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "First port:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			this.textBox3.AllowDrop = true;
			this.textBox3.Location = new System.Drawing.Point(110, 195);
			this.textBox3.MaxLength = 6;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(54, 21);
			this.textBox3.TabIndex = 7;
			this.textBox3.TabStop = false;
			// 
			// textBox4
			// 
			this.textBox4.AllowDrop = true;
			this.textBox4.Location = new System.Drawing.Point(110, 223);
			this.textBox4.MaxLength = 6;
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(54, 21);
			this.textBox4.TabIndex = 8;
			this.textBox4.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Second port:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "First port:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VSPDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.treeView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "VSPDForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CommTest";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button btnDeletePair;
		private System.Windows.Forms.Button btnCreate;
	}
}
