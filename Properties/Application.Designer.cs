
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



//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------



namespace TCP_CLIENT
{
	namespace My
	{
		
		//注意: 此文件是自动生成的；请不要直接修改它。若要进行更改，
		// 或者如果您在此文件中遇到生成错误，请转至项目设计器
		// (转至“项目属性”或在解决方案资源管理器中双击“我的项目”节点)，
		// 然后在“应用程序”选项卡中进行更改。
		//
		public partial class MyApplication : global::Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{
			[STAThread]
			static void Main()
			{
				(new MyApplication()).Run(new string[] {});
			}
			
			[global::System.Diagnostics.DebuggerStepThrough()]public MyApplication() : base(global::Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
			{
				
				
				
				this.IsSingleInstance = false;
				this.EnableVisualStyles = true;
				this.SaveMySettingsOnExit = true;
				this.ShutdownStyle = global::Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
			}
			
			[global::System.Diagnostics.DebuggerStepThroughAttribute()]protected override void OnCreateMainForm()
			{
				this.MainForm = global::TCP_CLIENT.Form1.Default;
			}
		}
	}
	
}