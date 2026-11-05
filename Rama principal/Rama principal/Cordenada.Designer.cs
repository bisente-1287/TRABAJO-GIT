/*
 * Created by SharpDevelop.
 * User: CC2_PC14
 * Date: 04/11/2026
 * Time: 03:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rama_principal
{
	partial class Cordenada
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(178, 204);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(94, 45);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cordenada x:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(172, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cordenada y:";
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(12, 39);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(100, 20);
			this.txtX.TabIndex = 3;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(172, 39);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(100, 20);
			this.txtY.TabIndex = 4;
			this.txtY.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(12, 62);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(260, 90);
			this.lblRespuesta.TabIndex = 5;
			// 
			// Cordenada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcular);
			this.Name = "Cordenada";
			this.Text = "Cordenada";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalcular;
	}
}
