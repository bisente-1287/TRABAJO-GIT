/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 04/11/2026
 * Time: 07:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rama_principal
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnDistanciaClick(object sender, EventArgs e)
		{
			txtDistancia3 f = new txtDistancia3();
			f.Show();
			this.Hide();
		}
		
		void BtnDoraresClick(object sender, EventArgs e)
		{
			Dolares D=new Dolares();
			D.Show();
			this.Hide();
		}
		
		void BtnCordenadaClick(object sender, EventArgs e)
		{
			Cordenada c = new Cordenada();
			c.Show();
			this.Hide();
		}
	}
}
