/*
 * Created by SharpDevelop.
 * User: CC2_PC14
 * Date: 04/11/2026
 * Time: 03:01 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rama_principal
{
	/// <summary>
	/// Description of Distancia.
	/// </summary>
	public partial class txtDistancia3 : Form
	{
		public txtDistancia3()
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
			double x1,x2,y1,y2,d;
			x1=Convert.ToDouble(txtDistancia1.Text);
			x2=Convert.ToDouble(txtDistancia2.Text);
			y1=Convert.ToDouble(txtDistancia33.Text);
		    y2=Convert.ToDouble(txtDistacia4.Text);
		    d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
		    MessageBox.Show("la distancia es: "+d);
		}
	}
}
