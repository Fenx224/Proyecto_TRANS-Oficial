/*
 * Created by SharpDevelop.
 * User: CC2_PC49
 * Date: 29/10/2024
 * Time: 07:52 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sharp_Project
{
	partial class LenguaYComunicacion
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
			this.btnJUEGO1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
<<<<<<< HEAD
=======
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
>>>>>>> bcdab8d15847fa5568e8ace71aed7e7098483519
			this.SuspendLayout();
			// 
			// btnJUEGO1
			// 
			this.btnJUEGO1.Location = new System.Drawing.Point(34, 370);
			this.btnJUEGO1.Name = "btnJUEGO1";
			this.btnJUEGO1.Size = new System.Drawing.Size(75, 23);
			this.btnJUEGO1.TabIndex = 0;
			this.btnJUEGO1.Text = "Entrar";
			this.btnJUEGO1.UseVisualStyleBackColor = true;
			this.btnJUEGO1.Click += new System.EventHandler(this.btnJUEGO1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lengua y Comunicación III";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "By: Juan Rafael González Díaz";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
<<<<<<< HEAD
			this.panel1.Location = new System.Drawing.Point(33, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(563, 182);
			this.panel1.TabIndex = 3;
			// 
=======
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(34, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(563, 295);
			this.panel1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "El ensayo";
			// 
>>>>>>> bcdab8d15847fa5568e8ace71aed7e7098483519
			// LenguaYComunicacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(630, 293);
=======
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(630, 405);
>>>>>>> bcdab8d15847fa5568e8ace71aed7e7098483519
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnJUEGO1);
			this.Name = "LenguaYComunicacion";
			this.Text = "LenguaYComunicacion";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
<<<<<<< HEAD
=======
		private System.Windows.Forms.Label label3;
>>>>>>> bcdab8d15847fa5568e8ace71aed7e7098483519
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnJUEGO1;
	}
}
