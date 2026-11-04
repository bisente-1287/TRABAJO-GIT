/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 04/11/2026
 * Time: 07:17 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TRABAJO_GERMAN
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
			string Nombre;
			string contraseña;
			Nombre="Admin";
			contraseña="1234";
			if(txtNombre.Text==Nombre || txtContraseña.Text==contraseña)
			{
				Form1 f = new Form1(txtNombre.Text);
				f
				this.Hide();
			}
			
		}
	}
}
