/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 04/11/2026
 * Time: 07:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rama_principal
{
	partial class Form1
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
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnDistancia = new System.Windows.Forms.Button();
			this.btnDorares = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCordenada = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(12, 214);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(238, 35);
			this.btnSalir.TabIndex = 0;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnDistancia
			// 
			this.btnDistancia.Location = new System.Drawing.Point(12, 163);
			this.btnDistancia.Name = "btnDistancia";
			this.btnDistancia.Size = new System.Drawing.Size(97, 38);
			this.btnDistancia.TabIndex = 1;
			this.btnDistancia.Text = "Distancia";
			this.btnDistancia.UseVisualStyleBackColor = true;
			this.btnDistancia.Click += new System.EventHandler(this.BtnDistanciaClick);
			// 
			// btnDorares
			// 
			this.btnDorares.Location = new System.Drawing.Point(75, 117);
			this.btnDorares.Name = "btnDorares";
			this.btnDorares.Size = new System.Drawing.Size(97, 40);
			this.btnDorares.TabIndex = 2;
			this.btnDorares.Text = "Dolares a pesos";
			this.btnDorares.UseVisualStyleBackColor = true;
			this.btnDorares.Click += new System.EventHandler(this.BtnDoraresClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 65);
			this.label1.TabIndex = 3;
			this.label1.Text = "Main menu";
			// 
			// btnCordenada
			// 
			this.btnCordenada.Location = new System.Drawing.Point(128, 164);
			this.btnCordenada.Name = "btnCordenada";
			this.btnCordenada.Size = new System.Drawing.Size(95, 37);
			this.btnCordenada.TabIndex = 4;
			this.btnCordenada.Text = "Cordenada 2 puntos";
			this.btnCordenada.UseVisualStyleBackColor = true;
			this.btnCordenada.Click += new System.EventHandler(this.BtnCordenadaClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 261);
			this.Controls.Add(this.btnCordenada);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDorares);
			this.Controls.Add(this.btnDistancia);
			this.Controls.Add(this.btnSalir);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCordenada;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDorares;
		private System.Windows.Forms.Button btnDistancia;
		private System.Windows.Forms.Button btnSalir;
	}
}
