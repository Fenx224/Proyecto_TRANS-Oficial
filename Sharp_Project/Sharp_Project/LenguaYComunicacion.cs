/*
 * Created by SharpDevelop.
 * User: CC2_PC49
 * Date: 29/10/2024
 * Time: 07:52 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sharp_Project
{
	/// <summary>
	/// Description of LenguaYComunicacion.
	/// </summary>
	public partial class LenguaYComunicacion : Form
	{
		public LenguaYComunicacion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void btnJUEGO1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.google.com");
		}
	}
}