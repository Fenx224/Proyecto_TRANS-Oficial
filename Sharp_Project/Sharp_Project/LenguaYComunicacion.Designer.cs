﻿/*
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LenguaYComunicacion));
			this.btnJUEGO1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnJUEGO2 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnJUEGO3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnJUEGO1
			// 
			this.btnJUEGO1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnJUEGO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJUEGO1.Location = new System.Drawing.Point(388, 170);
			this.btnJUEGO1.Name = "btnJUEGO1";
			this.btnJUEGO1.Size = new System.Drawing.Size(131, 57);
			this.btnJUEGO1.TabIndex = 0;
			this.btnJUEGO1.Text = "Responder preguntas sobre el ensayo";
			this.btnJUEGO1.UseVisualStyleBackColor = false;
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
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnJUEGO1);
			this.panel1.Location = new System.Drawing.Point(11, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(561, 252);
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(325, 203);
			this.label4.TabIndex = 3;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "El ensayo.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(343, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(197, 122);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.btnJUEGO2);
			this.panel2.Location = new System.Drawing.Point(11, 274);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(561, 340);
			this.panel2.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(325, 286);
			this.label5.TabIndex = 3;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(20, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "La reseña.";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(343, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(197, 122);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// btnJUEGO2
			// 
			this.btnJUEGO2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnJUEGO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJUEGO2.Location = new System.Drawing.Point(398, 213);
			this.btnJUEGO2.Name = "btnJUEGO2";
			this.btnJUEGO2.Size = new System.Drawing.Size(131, 57);
			this.btnJUEGO2.TabIndex = 0;
			this.btnJUEGO2.Text = "Responder preguntas sobre la reseña";
			this.btnJUEGO2.UseVisualStyleBackColor = false;
			this.btnJUEGO2.Click += new System.EventHandler(this.btnJUEGO2Click);
			// 
			// panel3
			// 
			this.panel3.AutoScroll = true;
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel1);
			this.panel3.Controls.Add(this.panel2);
			this.panel3.Location = new System.Drawing.Point(14, 59);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(608, 541);
			this.panel3.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.pictureBox3);
			this.panel4.Controls.Add(this.btnJUEGO3);
			this.panel4.Location = new System.Drawing.Point(11, 620);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(561, 358);
			this.panel4.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(10, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(325, 306);
			this.label7.TabIndex = 3;
			this.label7.Text = resources.GetString("label7.Text");
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(20, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(219, 23);
			this.label8.TabIndex = 2;
			this.label8.Text = "El comentario crítico.";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(343, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(197, 122);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// btnJUEGO3
			// 
			this.btnJUEGO3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnJUEGO3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJUEGO3.Location = new System.Drawing.Point(398, 213);
			this.btnJUEGO3.Name = "btnJUEGO3";
			this.btnJUEGO3.Size = new System.Drawing.Size(131, 57);
			this.btnJUEGO3.TabIndex = 0;
			this.btnJUEGO3.Text = "Responder preguntas sobre el comentario crítico";
			this.btnJUEGO3.UseVisualStyleBackColor = false;
			this.btnJUEGO3.Click += new System.EventHandler(this.BtnJUEGO3Click);
			// 
			// LenguaYComunicacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 612);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(640, 651);
			this.MinimumSize = new System.Drawing.Size(640, 651);
			this.Name = "LenguaYComunicacion";
			this.Text = "LenguaYComunicacion";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnJUEGO3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnJUEGO2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
/*<<<<<<< HEAD
=======
		private System.Windows.Forms.Label label3;
>>>>>>> bcdab8d15847fa5568e8ace71aed7e7098483519*/
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnJUEGO1;
	}
}
