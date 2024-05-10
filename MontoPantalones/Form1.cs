using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontoPantalones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cantidad = 0;
            double result = 0;

            cantidad = Convert.ToDouble(txtCantidad.Text);

            if (cantidad >= 3)
            {
                result = cantidad * 10;

                txtResultado.Text = Convert.ToString(result);
            }
            if (cantidad <3)
            {
                result = cantidad * 12;

                txtResultado.Text = Convert.ToString(result);
            }
        }
    }
}
