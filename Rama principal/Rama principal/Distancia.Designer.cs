/*
 * Created by SharpDevelop.
 * User: CC2_PC14
 * Date: 04/11/2026
 * Time: 03:01 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rama_principal
{
	partial class txtDistancia3
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
			this.txtDistancia2 = new System.Windows.Forms.TextBox();
			this.txtDistancia1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtDistacia4 = new System.Windows.Forms.TextBox();
			this.txtDistancia33 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "dis x1 y1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(163, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "dis x2 y2";
			// 
			// txtDistancia2
			// 
			this.txtDistancia2.Location = new System.Drawing.Point(163, 80);
			this.txtDistancia2.Name = "txtDistancia2";
			this.txtDistancia2.Size = new System.Drawing.Size(100, 20);
			this.txtDistancia2.TabIndex = 2;
			// 
			// txtDistancia1
			// 
			this.txtDistancia1.Location = new System.Drawing.Point(12, 80);
			this.txtDistancia1.Name = "txtDistancia1";
			this.txtDistancia1.Size = new System.Drawing.Size(100, 20);
			this.txtDistancia1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 178);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 91);
			this.button1.TabIndex = 4;
			this.button1.Text = "conversion";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtDistacia4
			// 
			this.txtDistacia4.Location = new System.Drawing.Point(163, 122);
			this.txtDistacia4.Name = "txtDistacia4";
			this.txtDistacia4.Size = new System.Drawing.Size(100, 20);
			this.txtDistacia4.TabIndex = 5;
			// 
			// txtDistancia33
			// 
			this.txtDistancia33.Location = new System.Drawing.Point(12, 122);
			this.txtDistancia33.Name = "txtDistancia33";
			this.txtDistancia33.Size = new System.Drawing.Size(100, 20);
			this.txtDistancia33.TabIndex = 6;
			// 
			// txtDistancia3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 291);
			this.Controls.Add(this.txtDistancia33);
			this.Controls.Add(this.txtDistacia4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtDistancia1);
			this.Controls.Add(this.txtDistancia2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "txtDistancia3";
			this.Text = "Distancia";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtDistancia33;
		private System.Windows.Forms.TextBox txtDistacia4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtDistancia1;
		private System.Windows.Forms.TextBox txtDistancia2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
