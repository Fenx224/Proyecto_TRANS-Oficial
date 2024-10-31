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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(264, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Humanidades";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(312, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Este es un sub titulo";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(686, 35);
			this.label3.TabIndex = 2;
			this.label3.Text = "La materia de humanidades nos trata de hablar sobre las distintas filosofias que " +
			"existen para que nosotros tratemos de generar un criterio y estilo de vida propi" +
			"os";
			// 
			// HumanidadesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 513);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "HumanidadesForm";
			this.Text = "HumanidadesForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
