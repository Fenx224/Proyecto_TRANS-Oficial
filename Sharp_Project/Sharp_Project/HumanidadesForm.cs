/*
 * Created by SharpDevelop.
 * User: CC-PC47
 * Date: 29/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sharp_Project
{
	/// <summary>
	/// Description of HumanidadesForm.
	/// </summary>
	public partial class HumanidadesForm : Form
	{
		public HumanidadesForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Humanidadesinfo Huin = new Humanidadesinfo();
			Huin.Show();
		}
	}
}
