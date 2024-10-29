/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 28/10/2024
 * Time: 08:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sharp_Project
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void CmbmateriasSelectedIndexChanged(object sender, EventArgs e)
		{
			string materiaSeleccionada = cmbMaterias.SelectedItem.ToString();

            // Abre un formulario basado en la materia seleccionada
            Form materiaForm;
            switch (materiaSeleccionada)
            {
                case "Matemáticas":
                    materiaForm = new MatematicasForm();
                    break;
                case "Inglés":
                    materiaForm = new InglesForm();
                    break;
                case "Física":
                    materiaForm = new Fisica();
                    break;
                case "Humanidades":
                    materiaForm = new HumanidadesForm();
                    break;
                case "Lengua y Comunicación":
                    materiaForm = new LenguaYComunicacion();
                    break;
                default:
                    materiaForm = null;
                    break;
            }

            if (materiaForm != null)
            {
                materiaForm.Show();
            }
		}
		
		void LBLacercadeClick(object sender, EventArgs e)
		{
			AcercaDe Acerca = new AcercaDe();
			Acerca.Show();
		}
	}
}
