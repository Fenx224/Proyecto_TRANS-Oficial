/*
 * Created by SharpDevelop.
 * User: CC-PC47
 * Date: 29/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sharp_Project
{
	partial class HumanidadesForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(178, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(247, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Humanidades";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(226, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Este es un sub titulo";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(522, 35);
			this.label3.TabIndex = 2;
			this.label3.Text = "La materia de humanidades nos trata de hablar sobre las distintas filosofias que " +
			"existen para que nosotros tratemos de generar un criterio y estilo de vida propi" +
			"os";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(48, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(178, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "El bien y el mal";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(48, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(522, 40);
			this.label5.TabIndex = 4;
			this.label5.Text = "Durante las clases, estuvimos debatiendo y respondiendo para nosotros la pregunta" +
			", ¿Que es el bien y mal?, y ¿Que es lo que esta bien y lo que no?,¿como definimo" +
			"s esto?";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(514, 356);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Entrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// HumanidadesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 382);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "HumanidadesForm";
			this.Text = "HumanidadesForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
