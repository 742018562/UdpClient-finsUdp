
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


using System.Net;
using System.Runtime.InteropServices;

namespace TCP_CLIENT
{
	public partial class Form1
	{
		public Form1()
		{
			InitializeComponent();
			
		    if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Form1 defaultInstance;
		

public static Form1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Form1();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion


        FinsUdp.PlcClient PLC = new FinsUdp.PlcClient();
		bool EntLink;
		long ScanCount;
        Int32 PlcHandle;
		
		[DllImport("winmm.dll", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern UInt32 timeGetTime();
		
		public void Form1_Load(System.Object sender, System.EventArgs e)
		{
			short i = 0;
			this.CenterToScreen();
			cmbReadMry.Items.Clear();
			cmbReadMry.Items.Add("CIO");
			cmbReadMry.Items.Add("WR");
			cmbReadMry.Items.Add("DR");
			cmbReadMry.Items.Add("ER");
            cmbReadMry.Items.Add("TIM");
            cmbReadMry.Items.Add("CNT");
			cmbWriteMry.Items.Clear();
			cmbWriteMry.Items.Add("CIO");
			cmbWriteMry.Items.Add("WR");
			cmbWriteMry.Items.Add("DR");
			cmbWriteMry.Items.Add("ER");
            cmbWriteMry.Items.Add("TIM");
            cmbWriteMry.Items.Add("CNT");
			cmbBitMry.Items.Clear();
			cmbBitMry.Items.Add("CIO");
			cmbBitMry.Items.Add("WR");
			cmbBitMry.Items.Add("DR");
            cmbBitMry.Items.Add("ER");
			cmbReadType.Items.Clear();
			cmbReadType.Items.Add("INT16");
			cmbReadType.Items.Add("UINT16");
			cmbReadType.Items.Add("DINT32");
			cmbReadType.Items.Add("HEX32");
			cmbReadType.Items.Add("REAL32");
			cmbReadType.Items.Add("BIN16");
            cmbReadType.Items.Add("BCD16");
            cmbReadType.Items.Add("BCD32");
			cmbWriteType.Items.Clear();
			cmbWriteType.Items.Add("INT16");
			cmbWriteType.Items.Add("UINT16");
			cmbWriteType.Items.Add("DINT32");
			cmbWriteType.Items.Add("HEX32");
			cmbWriteType.Items.Add("REAL32");
			cmbWriteType.Items.Add("BIN16");
            cmbWriteType.Items.Add("BCD16");
            cmbWriteType.Items.Add("BCD32");
			for (i = 0; i <= 15; i++)
			{
				cmbBit.Items.Add("Bit" + System.Convert.ToString(i));
			}
			cmbReadMry.SelectedIndex = 2;
			cmbWriteMry.SelectedIndex = 2;
			cmbBitMry.SelectedIndex = 0;
			cmbBit.SelectedIndex = 0;
			cmbReadType.SelectedIndex = 0;
			cmbWriteType.SelectedIndex = 0;
			lstRead.Items.Clear();
			txtWrite.Text = "";
			
		}
		
		
		public void butLink_Click(System.Object sender, System.EventArgs e)
		{
			short re = 0;
			string restr = "";
            re = PLC.EntLink(txtLocalIP.Text.Trim(), Convert.ToUInt16(txtLocalPort.Text), txtRemoteIP.Text.Trim(), (Convert.ToUInt16(txtRemotePort.Text)), "DEMO", ref PlcHandle, Convert.ToUInt16(1000));
			txtReLink.Text = re.ToString();
			if (re == 0)
			{
				EntLink = true;
				MessageBox.Show("PLC联接成功!");
			}
			else
			{
				EntLink = false;
				MessageBox.Show("PLC联接失败: " + restr);
			}
		}
		
		public void butClose_Click(System.Object sender, System.EventArgs e)
		{
			short re = 0;
            EntLink = false;
			re = PLC.DeLink(PlcHandle );
			txtReClose.Text = re.ToString();
		}
		
		public void butRead_Click(System.Object sender, System.EventArgs e)
		{
			short i = 0;
            short re = 0;
			object[] RD = null;
			RD = new object[Convert.ToUInt16(txtReadCnt.Text)];
			if (!EntLink)
			{
				MessageBox.Show("还未与PLC建立联接！");
				return;
			}
			int var1 = cmbReadType.SelectedIndex + 1;
            FinsUdp.PlcClient.DataType typ = (FinsUdp.PlcClient.DataType)var1;
			switch (cmbReadMry.SelectedIndex)
			{
				case 0:
                    re = PLC.CmdRead(PlcHandle,FinsUdp.PlcClient.PlcMemory.CIO, typ, Convert.ToUInt16(txtReadAdd.Text), Convert.ToUInt16(txtReadCnt.Text), ref RD);
					break;
				case 1:
                    re = PLC.CmdRead(PlcHandle, FinsUdp.PlcClient.PlcMemory.WR, typ, Convert.ToUInt16(txtReadAdd.Text), Convert.ToUInt16(txtReadCnt.Text), ref RD);
					break;
				case 2:
                    re = PLC.CmdRead(PlcHandle, FinsUdp.PlcClient.PlcMemory.DR, typ, Convert.ToUInt16(txtReadAdd.Text), Convert.ToUInt16(txtReadCnt.Text), ref RD);
					break;
				case 3:
                    re = PLC.CmdRead(PlcHandle, FinsUdp.PlcClient.PlcMemory.ER, typ, Convert.ToUInt16(txtReadAdd.Text), Convert.ToUInt16(txtReadCnt.Text), ref RD);
					break;
                case 4:
                    re = PLC.CmdRead(PlcHandle, FinsUdp.PlcClient.PlcMemory.TIM, typ, Convert.ToUInt16(txtReadAdd.Text), Convert.ToUInt16(txtReadCnt.Text), ref RD);
                    break;
                case 5:
                    re = PLC.CmdRead(PlcHandle, FinsUdp.PlcClient.PlcMemory.CNT, typ, Convert.ToUInt16(txtReadAdd.Text), Convert.ToUInt16(txtReadCnt.Text), ref RD);
                    break;
			}
			txtReRead.Text = re.ToString();
			lstRead.Items.Clear();
			for (i = 0; i < RD.Length; i++)
			{
				if (!(RD[i] == null))
				{
					lstRead.Items.Add(RD[i]);
				}
				else
				{
					lstRead.Items.Add("0");
				}
			}
			
		}
		
		
		public void butWrite_Click(System.Object sender, System.EventArgs e)
		{
			short i = 0;
            short re = 0;
			string[] temp = null;
			object[] WD = null;
			if (!EntLink)
			{
				MessageBox.Show("还未与PLC建立联接！");
				return;
			}
			WD = new object[Convert.ToUInt16(txtWriteCnt.Text)];
			temp = txtWrite.Text.Split('\n');
			for (i = 0; i < WD.Length; i++)
			{
				if (i >=temp.Length)
				{
					WD[i] = 0;
				}
				else
				{
					WD[i] = temp[i].Trim();
				}
			}
			int var1 = cmbWriteType.SelectedIndex + 1;
            FinsUdp.PlcClient.DataType typ = (FinsUdp.PlcClient.DataType)var1;
			switch (cmbWriteMry.SelectedIndex)
			{
				case 0:
                    re = PLC.CmdWrite(PlcHandle, FinsUdp.PlcClient.PlcMemory.CIO, typ, Convert.ToUInt16(txtWriteAdd.Text), Convert.ToUInt16(txtWriteCnt.Text), ref WD);
					break;
				case 1:
                    re = PLC.CmdWrite(PlcHandle, FinsUdp.PlcClient.PlcMemory.WR, typ, Convert.ToUInt16(txtWriteAdd.Text), Convert.ToUInt16(txtWriteCnt.Text), ref WD);
					break;
				case 2:
                    re = PLC.CmdWrite(PlcHandle, FinsUdp.PlcClient.PlcMemory.DR, typ, Convert.ToUInt16(txtWriteAdd.Text), Convert.ToUInt16(txtWriteCnt.Text), ref WD);
					break;
				case 3:
                    re = PLC.CmdWrite(PlcHandle, FinsUdp.PlcClient.PlcMemory.ER, typ, Convert.ToUInt16(txtWriteAdd.Text), Convert.ToUInt16(txtWriteCnt.Text), ref WD);
					break;
                case 4:
                    re = PLC.CmdWrite(PlcHandle, FinsUdp.PlcClient.PlcMemory.TIM, typ, Convert.ToUInt16(txtWriteAdd.Text), Convert.ToUInt16(txtWriteCnt.Text), ref WD);
                    break;
                case 5:
                    re = PLC.CmdWrite(PlcHandle, FinsUdp.PlcClient.PlcMemory.CNT, typ, Convert.ToUInt16(txtWriteAdd.Text), Convert.ToUInt16(txtWriteCnt.Text), ref WD);
                    break;
			}
			txtReWrite.Text = re.ToString();
		}
		
		public void butScan_Click(System.Object sender, System.EventArgs e)
		{
			if (!EntLink)
			{
				MessageBox.Show("还未与PLC建立联接！");
				return;
			}
			if (butScan.Text == "Cycle R/W")
			{
				ScanCount = 0;
				Timer1.Enabled = true;
				butScan.Text = "Stop R/W";
			}
			else
			{
				Timer1.Enabled = false;
				butScan.Text = "Cycle R/W";
			}
		}
		
		public void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
            Timer1.Enabled = false;
            int tim = System.Convert.ToInt32(timeGetTime());
            if (!EntLink)
            {
                MessageBox.Show("还未与PLC建立联接！");
                return;
            }
            //
            butRead_Click(null, null);
            butWrite_Click(null, null);

            //
            if ((Convert.ToInt32(txtReRead.Text) < 0) || (Convert.ToInt32(txtReWrite.Text) < 0))
            {
                butScan.Text = "Cycle R/W";
                return;
            }
            else
            {
                ScanCount++;
                txtScanCnt.Text = ScanCount.ToString();
                txtScanPrd.Text = (System.Convert.ToInt32(timeGetTime()) - tim).ToString() + "ms";
            }
            Timer1.Enabled = true;
		}
		
		
		public void butBitTest_Click(System.Object sender, System.EventArgs e)
		{
			if (!EntLink)
			{
				MessageBox.Show("还未与PLC建立联接！");
				return;
			}
			bool rd = false;
			short re = 0;
			switch (cmbBitMry.SelectedIndex)
			{
				case 0:
                    re = PLC.Bit_Test(PlcHandle, FinsUdp.PlcClient.PlcMemory.CIO, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex), ref rd);
					break;
				case 1:
                    re = PLC.Bit_Test(PlcHandle, FinsUdp.PlcClient.PlcMemory.WR, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex), ref rd);
					break;
				case 2:
                    re = PLC.Bit_Test(PlcHandle, FinsUdp.PlcClient.PlcMemory.DR, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex), ref rd);
					break;
                case 3:
                    re = PLC.Bit_Test(PlcHandle, FinsUdp.PlcClient.PlcMemory.ER, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex), ref rd);
                    break;
			}
			txtBitTest.Text = rd.ToString();
			txtReBit.Text = re.ToString();
		}
		
		public void butBitSet_Click(System.Object sender, System.EventArgs e)
		{
			if (!EntLink)
			{
				MessageBox.Show("还未与PLC建立联接！");
				return;
			}
			short re = 0;
			switch (cmbBitMry.SelectedIndex)
			{
				case 0:
                    re = PLC.Bit_Set(PlcHandle, FinsUdp.PlcClient.PlcMemory.CIO, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
					break;
				case 1:
                    re = PLC.Bit_Set(PlcHandle, FinsUdp.PlcClient.PlcMemory.WR, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
					break;
				case 2:
                    re = PLC.Bit_Set(PlcHandle, FinsUdp.PlcClient.PlcMemory.DR, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
					break;
                case 3:
                    re = PLC.Bit_Set(PlcHandle, FinsUdp.PlcClient.PlcMemory.ER, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
                    break;
			}
			txtReBit.Text = re.ToString();
		}
		
		public void butBitRst_Click(System.Object sender, System.EventArgs e)
		{
			if (!EntLink)
			{
				MessageBox.Show("还未与PLC建立联接！");
				return;
			}
			short re = 0;
			switch (cmbBitMry.SelectedIndex)
			{
				case 0:
                    re = PLC.Bit_Reset(PlcHandle, FinsUdp.PlcClient.PlcMemory.CIO, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
					break;
				case 1:
                    re = PLC.Bit_Reset(PlcHandle, FinsUdp.PlcClient.PlcMemory.WR, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
					break;
				case 2:
                    re = PLC.Bit_Reset(PlcHandle, FinsUdp.PlcClient.PlcMemory.DR, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
					break;
                case 3:
                    re = PLC.Bit_Reset(PlcHandle, FinsUdp.PlcClient.PlcMemory.ER, Convert.ToUInt16(txtBitAdd.Text), Convert.ToUInt16(cmbBit.SelectedIndex));
                    break;
			}
			txtReBit.Text = re.ToString();
		}
		
		
	}
	
}
