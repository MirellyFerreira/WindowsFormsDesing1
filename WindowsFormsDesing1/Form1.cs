using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDesing1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textn1.Text);
            int n2 = int.Parse(textn2.Text);

            int resultado = n1 + n2;

            labelResultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textn1.Clear();
            textn2.Clear();

            labelResultado.Text

            

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
