/*
 * Created by SharpDevelop.
 * User: CC-PC47
 * Date: 29/10/2024
 * Time: 07:40 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sharp_Project
{
	partial class MatematicasForm
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
			this.lblPromedio = new System.Windows.Forms.Label();
			this.lblReprobados = new System.Windows.Forms.Label();
			this.lblAprobados = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.lblMayor = new System.Windows.Forms.Label();
			this.lblPromAprobados = new System.Windows.Forms.Label();
			this.lblModa = new System.Windows.Forms.Label();
			this.txtCalificaciones = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPromedio
			// 
			this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPromedio.Location = new System.Drawing.Point(12, 162);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(254, 46);
			this.lblPromedio.TabIndex = 0;
			this.lblPromedio.Text = "$$$$$$";
			// 
			// lblReprobados
			// 
			this.lblReprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReprobados.Location = new System.Drawing.Point(272, 162);
			this.lblReprobados.Name = "lblReprobados";
			this.lblReprobados.Size = new System.Drawing.Size(254, 46);
			this.lblReprobados.TabIndex = 1;
			this.lblReprobados.Text = "$$$$$$";
			// 
			// lblAprobados
			// 
			this.lblAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAprobados.Location = new System.Drawing.Point(532, 162);
			this.lblAprobados.Name = "lblAprobados";
			this.lblAprobados.Size = new System.Drawing.Size(254, 46);
			this.lblAprobados.TabIndex = 2;
			this.lblAprobados.Text = "$$$$$$";
			// 
			// lblMenor
			// 
			this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenor.Location = new System.Drawing.Point(272, 208);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(254, 46);
			this.lblMenor.TabIndex = 4;
			this.lblMenor.Text = "$$$$$$";
			// 
			// lblMayor
			// 
			this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMayor.Location = new System.Drawing.Point(12, 208);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(254, 46);
			this.lblMayor.TabIndex = 3;
			this.lblMayor.Text = "$$$$$$";
			// 
			// lblPromAprobados
			// 
			this.lblPromAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPromAprobados.Location = new System.Drawing.Point(272, 254);
			this.lblPromAprobados.Name = "lblPromAprobados";
			this.lblPromAprobados.Size = new System.Drawing.Size(344, 46);
			this.lblPromAprobados.TabIndex = 8;
			this.lblPromAprobados.Text = "$$$$$$";
			// 
			// lblModa
			// 
			this.lblModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModa.Location = new System.Drawing.Point(12, 254);
			this.lblModa.Name = "lblModa";
			this.lblModa.Size = new System.Drawing.Size(254, 46);
			this.lblModa.TabIndex = 6;
			this.lblModa.Text = "$$$$$$";
			// 
			// txtCalificaciones
			// 
			this.txtCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalificaciones.Location = new System.Drawing.Point(12, 12);
			this.txtCalificaciones.Multiline = true;
			this.txtCalificaciones.Name = "txtCalificaciones";
			this.txtCalificaciones.Size = new System.Drawing.Size(818, 78);
			this.txtCalificaciones.TabIndex = 9;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(287, 373);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(300, 89);
			this.btnCalcular.TabIndex = 10;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// MatematicasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 474);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtCalificaciones);
			this.Controls.Add(this.lblPromAprobados);
			this.Controls.Add(this.lblModa);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.lblAprobados);
			this.Controls.Add(this.lblReprobados);
			this.Controls.Add(this.lblPromedio);
			this.Name = "MatematicasForm";
			this.Text = "MatematicasForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtCalificaciones;
		private System.Windows.Forms.Label lblModa;
		private System.Windows.Forms.Label lblPromAprobados;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label lblAprobados;
		private System.Windows.Forms.Label lblReprobados;
		private System.Windows.Forms.Label lblPromedio;
	}
}
