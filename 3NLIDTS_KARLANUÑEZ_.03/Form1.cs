using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_KARLANUÑEZ_._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            float Celsius = float.Parse(tbCelsius.Text);
            float Farenheit = (Celsius * 9f / 5f) + 32;
            tbFahrenheit.Text = Farenheit.ToString();
        }

        private void btnFarenheit_Click(object sender, EventArgs e)
        {
            float Farenheit = float.Parse(tbFahrenheit.Text);
            float Celsius = (Farenheit - 32)*5.0f / 9;
            tbCelsius.Text = Celsius.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbFahrenheit.Text = "0.0";
            tbCelsius.Text = "0.0";
            MessageBox.Show("Se resetearon los valores de los TextBox");
        }
    }
}

