﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC49
 * Date: 29/10/2024
 * Time: 07:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sharp_Project
{
	/// <summary>
	/// Description of Fisica.
	/// </summary>
	public partial class Fisica : Form
	{
		public Fisica()
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
			int M,F,rel;
			M= int.Parse(textBox1.Text);
			F= int.Parse(textBox2.Text);
			rel=F/M;
			label10.Text="Resultado = " + rel.ToString();
			
		}
	}
}
