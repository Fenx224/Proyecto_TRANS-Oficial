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
			// Obtener todas las calificaciones desde el TextBox
            string input = txtCalificaciones.Text;

            // Separar las calificaciones por comas, espacios o saltos de línea
            string[] califArray = input.Split(new char[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Variables para cálculos
            int suma = 0;
            int sumaAprobados = 0;
            int aprobados = 0;
            int reprobados = 0;
            int mayor = int.MinValue;
            int menor = int.MaxValue;
            int totalCalificaciones = califArray.Length;

            // Diccionario para contar la moda
            int[] conteo = new int[101]; // Asume que las calificaciones son entre 0 y 100
            int moda = 0;
            int maxCount = 0;

            for (int i = 0; i < totalCalificaciones; i++)
            {
                int calificacion;
                if (int.TryParse(califArray[i], out calificacion))
                {
                    // Sumar para el promedio total
                    suma += calificacion;

                    // Calcular mayor y menor
                    if (calificacion > mayor) mayor = calificacion;
                    if (calificacion < menor) menor = calificacion;

                    // Contar aprobados y reprobados, y sumar aprobados para su promedio
                    if (calificacion >= 60)
                    {
                        aprobados++;
                        sumaAprobados += calificacion;
                    }
                    else
                    {
                        reprobados++;
                    }

                    // Calcular moda usando el conteo
                    conteo[calificacion]++;
                    if (conteo[calificacion] > maxCount)
                    {
                        maxCount = conteo[calificacion];
                        moda = calificacion;
                    }
                }
            }

            // Verificar que haya calificaciones válidas para evitar división por cero
            if (totalCalificaciones > 0)
            {
                double promedio = (double)suma / totalCalificaciones;
                double promedioAprobados = aprobados > 0 ? (double)sumaAprobados / aprobados : 0;

                // Mostrar resultados en los labels
                lblPromedio.Text = "Promedio: " + promedio;
                lblMayor.Text = "Mayor: " + mayor;
                lblMenor.Text = "Menor: " + menor;
                lblAprobados.Text = "Aprobados: " + aprobados;
                lblReprobados.Text = "Reprobados: " + reprobados;
                lblPromAprobados.Text = "Promedio Aprobados: " + promedioAprobados;
                lblModa.Text = "Moda: " + moda;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa  al menos una calificación válida.");
            }
		}
	}
}
