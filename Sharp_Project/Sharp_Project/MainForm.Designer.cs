/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 28/10/2024
 * Time: 08:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sharp_Project
{
	partial class MainForm
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
			this.cmbMaterias = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LBLacercade = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmbMaterias
			// 
			this.cmbMaterias.FormattingEnabled = true;
			this.cmbMaterias.Items.AddRange(new object[] {
									"Matemáticas",
									"Inglés",
									"Física",
									"Humanidades",
									"Lengua y Comunicación"});
			this.cmbMaterias.Location = new System.Drawing.Point(80, 79);
			this.cmbMaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbMaterias.Name = "cmbMaterias";
			this.cmbMaterias.Size = new System.Drawing.Size(299, 24);
			this.cmbMaterias.TabIndex = 0;
			this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.CmbmateriasSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(157, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selecciona la materia";
			// 
			// LBLacercade
			// 
			this.LBLacercade.Location = new System.Drawing.Point(547, 519);
			this.LBLacercade.Name = "LBLacercade";
			this.LBLacercade.Size = new System.Drawing.Size(95, 23);
			this.LBLacercade.TabIndex = 2;
			this.LBLacercade.Text = "Acerca De";
			this.LBLacercade.Click += new System.EventHandler(this.LBLacercadeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 551);
			this.Controls.Add(this.LBLacercade);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMaterias);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Sharp_Project";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label LBLacercade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbMaterias;
	}
}
