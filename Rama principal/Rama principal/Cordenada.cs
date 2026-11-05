/*
 * Created by SharpDevelop.
 * User: CC2_PC14
 * Date: 04/11/2026
 * Time: 03:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rama_principal
{
	/// <summary>
	/// Description of Cordenada.
	/// </summary>
	public partial class Cordenada : Form
	{
		public Cordenada()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			int x,y;
			x=Convert.ToInt32(txtX.Text);
			y=Convert.ToInt32(txtY.Text);
			if(x>0 && y>0)
				lblRespuesta.Text="Cuadrante 1";
			else if (x>0 && y<0)
				lblRespuesta.Text="Cuadrante 2";
			else if(x<0 && y<0)
				lblRespuesta.Text="Cuadrante 3";
			else if(x<0 && y>0)
				lblRespuesta.Text="Cuadrante 4";
			else
				lblRespuesta.Text=("El punto se encuentra en el centro (0,0)");
			
		}
	}
}
