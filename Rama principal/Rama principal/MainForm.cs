/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 04/11/2026
 * Time: 07:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rama_principal
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string Usuario;
			string Contraseña;
			Contraseña="1234";
			Usuario="Pepe";
			
			if(txtContraseña.Text == Contraseña && txtUsuario.Text == Usuario )
			{
				Form1 f= new Form1();
				f.Show();
				this.Hide();
				
				
			}
			if(txtContraseña.Text != Contraseña || txtUsuario.Text != Usuario )
			{
				MessageBox.Show("EL usuario o contraseña es incorrecto");
			}
			
			
			
		}
	}
}
