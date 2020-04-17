
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;



namespace TCP_CLIENT
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

        //Windows 窗体设计器所必需的
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.butLink = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.butScan = new System.Windows.Forms.Button();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReRead = new System.Windows.Forms.TextBox();
            this.cmbReadType = new System.Windows.Forms.ComboBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.butRead = new System.Windows.Forms.Button();
            this.lstRead = new System.Windows.Forms.ListBox();
            this.cmbReadMry = new System.Windows.Forms.ComboBox();
            this.txtReadAdd = new System.Windows.Forms.TextBox();
            this.txtReadCnt = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbWriteType = new System.Windows.Forms.ComboBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.txtReWrite = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.butWrite = new System.Windows.Forms.Button();
            this.cmbWriteMry = new System.Windows.Forms.ComboBox();
            this.txtWriteAdd = new System.Windows.Forms.TextBox();
            this.txtWriteCnt = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtScanCnt = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtScanPrd = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtReClose = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtReLink = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtReBit = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.cmbBit = new System.Windows.Forms.ComboBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.txtBitAdd = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.cmbBitMry = new System.Windows.Forms.ComboBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.butBitRst = new System.Windows.Forms.Button();
            this.butBitSet = new System.Windows.Forms.Button();
            this.butBitTest = new System.Windows.Forms.Button();
            this.txtBitTest = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // butLink
            // 
            this.butLink.Location = new System.Drawing.Point(416, 10);
            this.butLink.Name = "butLink";
            this.butLink.Size = new System.Drawing.Size(88, 26);
            this.butLink.TabIndex = 3;
            this.butLink.Text = "EntLink";
            this.butLink.UseVisualStyleBackColor = true;
            this.butLink.Click += new System.EventHandler(this.butLink_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(416, 45);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(88, 26);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "DeLink";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // butScan
            // 
            this.butScan.Location = new System.Drawing.Point(406, 428);
            this.butScan.Name = "butScan";
            this.butScan.Size = new System.Drawing.Size(88, 30);
            this.butScan.TabIndex = 10;
            this.butScan.Text = "Cycle R/W";
            this.butScan.UseVisualStyleBackColor = true;
            this.butScan.Click += new System.EventHandler(this.butScan_Click);
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(62, 12);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.Size = new System.Drawing.Size(100, 21);
            this.txtLocalIP.TabIndex = 22;
            this.txtLocalIP.Text = "192.168.250.70";
            this.txtLocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 12);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "LocalIP";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(177, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 12);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "LocalPort";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(242, 12);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(44, 21);
            this.txtLocalPort.TabIndex = 24;
            this.txtLocalPort.Text = "0";
            this.txtLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(177, 51);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 12);
            this.Label3.TabIndex = 29;
            this.Label3.Text = "RemotePort";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(242, 48);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(44, 21);
            this.txtRemotePort.TabIndex = 28;
            this.txtRemotePort.Text = "9600";
            this.txtRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(3, 51);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 12);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "RemoteIP";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(62, 48);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(100, 21);
            this.txtRemoteIP.TabIndex = 26;
            this.txtRemoteIP.Text = "192.168.250.1";
            this.txtRemoteIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox14
            // 
            this.TextBox14.Location = new System.Drawing.Point(989, 215);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.Size = new System.Drawing.Size(66, 21);
            this.TextBox14.TabIndex = 35;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(953, 220);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(35, 12);
            this.Label12.TabIndex = 50;
            this.Label12.Text = "Count";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtReRead);
            this.GroupBox1.Controls.Add(this.cmbReadType);
            this.GroupBox1.Controls.Add(this.Label24);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.butRead);
            this.GroupBox1.Controls.Add(this.lstRead);
            this.GroupBox1.Controls.Add(this.cmbReadMry);
            this.GroupBox1.Controls.Add(this.txtReadAdd);
            this.GroupBox1.Controls.Add(this.txtReadCnt);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Location = new System.Drawing.Point(5, 176);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(242, 243);
            this.GroupBox1.TabIndex = 51;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Read";
            // 
            // txtReRead
            // 
            this.txtReRead.Location = new System.Drawing.Point(161, 169);
            this.txtReRead.Name = "txtReRead";
            this.txtReRead.ReadOnly = true;
            this.txtReRead.Size = new System.Drawing.Size(66, 21);
            this.txtReRead.TabIndex = 52;
            this.txtReRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbReadType
            // 
            this.cmbReadType.FormattingEnabled = true;
            this.cmbReadType.Location = new System.Drawing.Point(161, 57);
            this.cmbReadType.Name = "cmbReadType";
            this.cmbReadType.Size = new System.Drawing.Size(66, 20);
            this.cmbReadType.TabIndex = 58;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(128, 61);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(29, 12);
            this.Label24.TabIndex = 56;
            this.Label24.Text = "Type";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(116, 173);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(41, 12);
            this.Label9.TabIndex = 53;
            this.Label9.Text = "Return";
            // 
            // butRead
            // 
            this.butRead.Location = new System.Drawing.Point(139, 203);
            this.butRead.Name = "butRead";
            this.butRead.Size = new System.Drawing.Size(88, 26);
            this.butRead.TabIndex = 51;
            this.butRead.Text = "Cmd Read";
            this.butRead.UseVisualStyleBackColor = true;
            this.butRead.Click += new System.EventHandler(this.butRead_Click);
            // 
            // lstRead
            // 
            this.lstRead.FormattingEnabled = true;
            this.lstRead.ItemHeight = 12;
            this.lstRead.Location = new System.Drawing.Point(11, 20);
            this.lstRead.Name = "lstRead";
            this.lstRead.ScrollAlwaysVisible = true;
            this.lstRead.Size = new System.Drawing.Size(91, 208);
            this.lstRead.TabIndex = 50;
            // 
            // cmbReadMry
            // 
            this.cmbReadMry.FormattingEnabled = true;
            this.cmbReadMry.Location = new System.Drawing.Point(161, 22);
            this.cmbReadMry.Name = "cmbReadMry";
            this.cmbReadMry.Size = new System.Drawing.Size(66, 20);
            this.cmbReadMry.TabIndex = 40;
            // 
            // txtReadAdd
            // 
            this.txtReadAdd.Location = new System.Drawing.Point(161, 93);
            this.txtReadAdd.Name = "txtReadAdd";
            this.txtReadAdd.Size = new System.Drawing.Size(66, 21);
            this.txtReadAdd.TabIndex = 36;
            this.txtReadAdd.Text = "0";
            this.txtReadAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReadCnt
            // 
            this.txtReadCnt.Location = new System.Drawing.Point(161, 131);
            this.txtReadCnt.Name = "txtReadCnt";
            this.txtReadCnt.Size = new System.Drawing.Size(66, 21);
            this.txtReadCnt.TabIndex = 38;
            this.txtReadCnt.Text = "5";
            this.txtReadCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(122, 135);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(35, 12);
            this.Label11.TabIndex = 49;
            this.Label11.Text = "Count";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(116, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(41, 12);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Memory";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(110, 97);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 12);
            this.Label7.TabIndex = 43;
            this.Label7.Text = "Address";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cmbWriteType);
            this.GroupBox2.Controls.Add(this.Label23);
            this.GroupBox2.Controls.Add(this.txtWrite);
            this.GroupBox2.Controls.Add(this.txtReWrite);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.butWrite);
            this.GroupBox2.Controls.Add(this.cmbWriteMry);
            this.GroupBox2.Controls.Add(this.txtWriteAdd);
            this.GroupBox2.Controls.Add(this.txtWriteCnt);
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.Label14);
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Location = new System.Drawing.Point(262, 176);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(245, 243);
            this.GroupBox2.TabIndex = 53;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Write";
            // 
            // cmbWriteType
            // 
            this.cmbWriteType.FormattingEnabled = true;
            this.cmbWriteType.Location = new System.Drawing.Point(166, 57);
            this.cmbWriteType.Name = "cmbWriteType";
            this.cmbWriteType.Size = new System.Drawing.Size(66, 20);
            this.cmbWriteType.TabIndex = 57;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(133, 61);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(29, 12);
            this.Label23.TabIndex = 55;
            this.Label23.Text = "Type";
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(12, 20);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWrite.Size = new System.Drawing.Size(91, 210);
            this.txtWrite.TabIndex = 54;
            // 
            // txtReWrite
            // 
            this.txtReWrite.Location = new System.Drawing.Point(166, 169);
            this.txtReWrite.Name = "txtReWrite";
            this.txtReWrite.ReadOnly = true;
            this.txtReWrite.Size = new System.Drawing.Size(66, 21);
            this.txtReWrite.TabIndex = 52;
            this.txtReWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(121, 173);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(41, 12);
            this.Label10.TabIndex = 53;
            this.Label10.Text = "Return";
            // 
            // butWrite
            // 
            this.butWrite.Location = new System.Drawing.Point(144, 203);
            this.butWrite.Name = "butWrite";
            this.butWrite.Size = new System.Drawing.Size(88, 26);
            this.butWrite.TabIndex = 51;
            this.butWrite.Text = "Cmd Write";
            this.butWrite.UseVisualStyleBackColor = true;
            this.butWrite.Click += new System.EventHandler(this.butWrite_Click);
            // 
            // cmbWriteMry
            // 
            this.cmbWriteMry.FormattingEnabled = true;
            this.cmbWriteMry.Location = new System.Drawing.Point(166, 22);
            this.cmbWriteMry.Name = "cmbWriteMry";
            this.cmbWriteMry.Size = new System.Drawing.Size(66, 20);
            this.cmbWriteMry.TabIndex = 40;
            // 
            // txtWriteAdd
            // 
            this.txtWriteAdd.Location = new System.Drawing.Point(166, 93);
            this.txtWriteAdd.Name = "txtWriteAdd";
            this.txtWriteAdd.Size = new System.Drawing.Size(66, 21);
            this.txtWriteAdd.TabIndex = 36;
            this.txtWriteAdd.Text = "0";
            this.txtWriteAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWriteCnt
            // 
            this.txtWriteCnt.Location = new System.Drawing.Point(166, 131);
            this.txtWriteCnt.Name = "txtWriteCnt";
            this.txtWriteCnt.Size = new System.Drawing.Size(66, 21);
            this.txtWriteCnt.TabIndex = 38;
            this.txtWriteCnt.Text = "1";
            this.txtWriteCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(127, 135);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(35, 12);
            this.Label13.TabIndex = 49;
            this.Label13.Text = "Count";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(121, 26);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(41, 12);
            this.Label14.TabIndex = 39;
            this.Label14.Text = "Memory";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(114, 97);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(47, 12);
            this.Label15.TabIndex = 43;
            this.Label15.Text = "Address";
            // 
            // txtScanCnt
            // 
            this.txtScanCnt.Location = new System.Drawing.Point(62, 434);
            this.txtScanCnt.Name = "txtScanCnt";
            this.txtScanCnt.ReadOnly = true;
            this.txtScanCnt.Size = new System.Drawing.Size(66, 21);
            this.txtScanCnt.TabIndex = 54;
            this.txtScanCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(17, 437);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(47, 12);
            this.Label16.TabIndex = 55;
            this.Label16.Text = "Counter";
            // 
            // txtScanPrd
            // 
            this.txtScanPrd.Location = new System.Drawing.Point(249, 434);
            this.txtScanPrd.Name = "txtScanPrd";
            this.txtScanPrd.ReadOnly = true;
            this.txtScanPrd.Size = new System.Drawing.Size(66, 21);
            this.txtScanPrd.TabIndex = 56;
            this.txtScanPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(202, 437);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(41, 12);
            this.Label17.TabIndex = 57;
            this.Label17.Text = "Period";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(299, 52);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 12);
            this.Label6.TabIndex = 61;
            this.Label6.Text = "Re.DeLink";
            // 
            // txtReClose
            // 
            this.txtReClose.Location = new System.Drawing.Point(358, 49);
            this.txtReClose.Name = "txtReClose";
            this.txtReClose.ReadOnly = true;
            this.txtReClose.Size = new System.Drawing.Size(44, 21);
            this.txtReClose.TabIndex = 60;
            this.txtReClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(305, 16);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(47, 12);
            this.Label8.TabIndex = 59;
            this.Label8.Text = "Re.Link";
            // 
            // txtReLink
            // 
            this.txtReLink.Location = new System.Drawing.Point(358, 13);
            this.txtReLink.Name = "txtReLink";
            this.txtReLink.ReadOnly = true;
            this.txtReLink.Size = new System.Drawing.Size(44, 21);
            this.txtReLink.TabIndex = 58;
            this.txtReLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtReBit);
            this.GroupBox3.Controls.Add(this.Label22);
            this.GroupBox3.Controls.Add(this.cmbBit);
            this.GroupBox3.Controls.Add(this.Label21);
            this.GroupBox3.Controls.Add(this.txtBitAdd);
            this.GroupBox3.Controls.Add(this.Label20);
            this.GroupBox3.Controls.Add(this.cmbBitMry);
            this.GroupBox3.Controls.Add(this.Label19);
            this.GroupBox3.Controls.Add(this.butBitRst);
            this.GroupBox3.Controls.Add(this.butBitSet);
            this.GroupBox3.Controls.Add(this.butBitTest);
            this.GroupBox3.Controls.Add(this.txtBitTest);
            this.GroupBox3.Controls.Add(this.Label18);
            this.GroupBox3.Location = new System.Drawing.Point(5, 76);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(502, 94);
            this.GroupBox3.TabIndex = 62;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Bit Opera.";
            // 
            // txtReBit
            // 
            this.txtReBit.Location = new System.Drawing.Point(423, 21);
            this.txtReBit.Name = "txtReBit";
            this.txtReBit.ReadOnly = true;
            this.txtReBit.Size = new System.Drawing.Size(66, 21);
            this.txtReBit.TabIndex = 61;
            this.txtReBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(374, 25);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(41, 12);
            this.Label22.TabIndex = 62;
            this.Label22.Text = "Return";
            // 
            // cmbBit
            // 
            this.cmbBit.FormattingEnabled = true;
            this.cmbBit.Location = new System.Drawing.Point(290, 21);
            this.cmbBit.Name = "cmbBit";
            this.cmbBit.Size = new System.Drawing.Size(66, 20);
            this.cmbBit.TabIndex = 60;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(263, 24);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(23, 12);
            this.Label21.TabIndex = 59;
            this.Label21.Text = "Bit";
            // 
            // txtBitAdd
            // 
            this.txtBitAdd.Location = new System.Drawing.Point(197, 21);
            this.txtBitAdd.Name = "txtBitAdd";
            this.txtBitAdd.Size = new System.Drawing.Size(50, 21);
            this.txtBitAdd.TabIndex = 57;
            this.txtBitAdd.Text = "100";
            this.txtBitAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(142, 24);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(59, 12);
            this.Label20.TabIndex = 58;
            this.Label20.Text = "Word Num.";
            // 
            // cmbBitMry
            // 
            this.cmbBitMry.FormattingEnabled = true;
            this.cmbBitMry.Location = new System.Drawing.Point(62, 21);
            this.cmbBitMry.Name = "cmbBitMry";
            this.cmbBitMry.Size = new System.Drawing.Size(66, 20);
            this.cmbBitMry.TabIndex = 56;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(19, 26);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(41, 12);
            this.Label19.TabIndex = 55;
            this.Label19.Text = "Memory";
            // 
            // butBitRst
            // 
            this.butBitRst.Location = new System.Drawing.Point(397, 55);
            this.butBitRst.Name = "butBitRst";
            this.butBitRst.Size = new System.Drawing.Size(88, 26);
            this.butBitRst.TabIndex = 54;
            this.butBitRst.Text = "Bit Reset";
            this.butBitRst.UseVisualStyleBackColor = true;
            this.butBitRst.Click += new System.EventHandler(this.butBitRst_Click);
            // 
            // butBitSet
            // 
            this.butBitSet.Location = new System.Drawing.Point(250, 55);
            this.butBitSet.Name = "butBitSet";
            this.butBitSet.Size = new System.Drawing.Size(88, 26);
            this.butBitSet.TabIndex = 53;
            this.butBitSet.Text = "Bit Set.";
            this.butBitSet.UseVisualStyleBackColor = true;
            this.butBitSet.Click += new System.EventHandler(this.butBitSet_Click);
            // 
            // butBitTest
            // 
            this.butBitTest.Location = new System.Drawing.Point(20, 55);
            this.butBitTest.Name = "butBitTest";
            this.butBitTest.Size = new System.Drawing.Size(88, 26);
            this.butBitTest.TabIndex = 52;
            this.butBitTest.Text = "Bit Test";
            this.butBitTest.UseVisualStyleBackColor = true;
            this.butBitTest.Click += new System.EventHandler(this.butBitTest_Click);
            // 
            // txtBitTest
            // 
            this.txtBitTest.Location = new System.Drawing.Point(115, 59);
            this.txtBitTest.Name = "txtBitTest";
            this.txtBitTest.ReadOnly = true;
            this.txtBitTest.Size = new System.Drawing.Size(66, 21);
            this.txtBitTest.TabIndex = 44;
            this.txtBitTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(6, 26);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(0, 12);
            this.Label18.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 468);
            this.Controls.Add(this.txtRemotePort);
            this.Controls.Add(this.txtReClose);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtReLink);
            this.Controls.Add(this.txtScanPrd);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.txtScanCnt);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.TextBox14);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtRemoteIP);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtLocalIP);
            this.Controls.Add(this.butScan);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "DLL Testing for OMRON EtherNet UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button butLink;
		internal System.Windows.Forms.Button butClose;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Button butScan;
		internal System.Windows.Forms.TextBox txtLocalIP;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtLocalPort;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtRemotePort;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtRemoteIP;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txtReadAdd;
		internal System.Windows.Forms.TextBox txtReadCnt;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ComboBox cmbReadMry;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.ListBox lstRead;
		internal System.Windows.Forms.Button butRead;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button butWrite;
		internal System.Windows.Forms.ComboBox cmbWriteMry;
		internal System.Windows.Forms.TextBox txtWriteAdd;
		internal System.Windows.Forms.TextBox txtWriteCnt;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtScanCnt;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox txtScanPrd;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtReClose;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtReLink;
		internal System.Windows.Forms.TextBox txtReRead;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtReWrite;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Button butBitRst;
		internal System.Windows.Forms.Button butBitSet;
		internal System.Windows.Forms.Button butBitTest;
		internal System.Windows.Forms.TextBox txtBitTest;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.ComboBox cmbBit;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.TextBox txtBitAdd;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.ComboBox cmbBitMry;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox txtWrite;
		internal System.Windows.Forms.TextBox txtReBit;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.ComboBox cmbReadType;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.ComboBox cmbWriteType;
        internal System.Windows.Forms.Label Label23;
        private System.ComponentModel.IContainer components;
		
	}
	
}
