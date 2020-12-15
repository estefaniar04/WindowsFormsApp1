using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class numRectangulo1 : Form
    {
        public numRectangulo1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
           decimal resultado = a.Cuadrado(numCuadrado2.Value);
            lblAreaCuadrado.Text = resultado + "";
        }

        private void numDato_ValueChanged(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Triangulo(numDato1.Value, numDato2.Value);
            lblAreaTriangulo.Text = resultado + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                CAreas a = new CAreas();
                decimal resultado = a.Rectangulo(numDato1.Value, numDato2.Value);
                lblAreaRectangulo.Text = resultado + "";
             }

        }

        private void btnAreaCubo_Click(object sender, EventArgs e)
        {
            {
                CAreas a = new CAreas();
                decimal resultado = a.Cubo(numDato1.Value);
                lblAreaCubo.Text = resultado + "";
            }
        }
    }

}