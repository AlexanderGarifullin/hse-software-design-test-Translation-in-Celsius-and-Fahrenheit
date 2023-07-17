using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestGradus.ServiceReference1;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace TestGradus
{
    public partial class FormDegree : Form
    {
        public FormDegree()
        {
            InitializeComponent();
        }

        private void btnCInF_Click(object sender, EventArgs e)
        {
            double degreeC = 0;
            if (Double.TryParse(textBoxCelFirst.Text, out degreeC))
            {
                ViewCInF(degreeC);
            }
            else
            {
                MessageBox.Show($"Ошибка! Не числовое значение {textBoxCelFirst.Text}!" ); 
            }
        }

        private void ViewCInF(double c)
        {
            using (var client = new ConversionServiceClient()) { 
                double f = client.CelsiusToFahrenheit(c);
                textBoxFarFirst.Text = f.ToString();
            }
        }

        private void btnFInC_Click(object sender, EventArgs e)
        {
            double degreeF = 0;
            if (Double.TryParse(textBoxFarFirst.Text, out degreeF))
            {
                ViewFInC(degreeF);
            }
            else
            {
                MessageBox.Show($"Ошибка! Не числовое значение {textBoxFarFirst.Text}!");
            }
        }
        private void ViewFInC(double f)
        {
            using (var client = new ConversionServiceClient())
            {
                double c = client.FahrenheitToCelsius(f);
                textBoxCelSecond.Text = c.ToString();
            }
        }
    }
}
