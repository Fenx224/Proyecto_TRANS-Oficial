/*
 * Created by SharpDevelop.
 * User: CC-PC47
 * Date: 29/10/2024
 * Time: 07:40 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sharp_Project
{
	/// <summary>
	/// Description of MatematicasForm.
	/// </summary>
	public partial class MatematicasForm : Form
	{
		public MatematicasForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			// Tomar todas las calificaciones del TextBox
            string input = txtCalificaciones.Text;

            // Separar las calificaciones por comas, espacios o saltos de línea
            string[] califArray = input.Split(new char[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Convertir el array en una lista de enteros
            List<int> calificaciones = new List<int>();
            foreach (string califStr in califArray)
            {
                int calif;
                if (int.TryParse(califStr, out calif))
                {
                    calificaciones.Add(calif);
                }
            }

            // Validar que haya exactamente 50 calificaciones
            if (calificaciones.Count == 50)
            {
                // Calcular estadísticas básicas
                int suma = 0, aprobados = 0, reprobados = 0;
                int mayor = calificaciones[0];
                int menor = calificaciones[0];

                foreach (int calificacion in calificaciones)
                {
                    suma += calificacion;
                    if (calificacion >= 60)
                        aprobados++;
                    else
                        reprobados++;

                    if (calificacion > mayor) mayor = calificacion;
                    if (calificacion < menor) menor = calificacion;
                }

                // Calcular el promedio
                double promedio = (double)suma / calificaciones.Count;

                // Actualizar los labels con los resultados
                lblPromedio.Text = "Promedio: " + promedio;
                lblReprobados.Text = "Reprobados: " + reprobados;
                lblAprobados.Text = "Aprobados: " + aprobados;
                lblMayor.Text = "Mayor: " + mayor;
                lblMenor.Text = "Menor: " + menor;
                lblPromAprobados = "PromAprobados: " +
            }
            else
            {
                MessageBox.Show("Por favor, ingresa exactamente 50 calificaciones válidas.");
            }
            
            
		}
	}
}
