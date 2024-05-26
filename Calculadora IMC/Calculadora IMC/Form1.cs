using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_CalculadoraIMC_Click(object sender, EventArgs e)
        {
            //Criando uma instância do segundo formulário
            Form2 form2 = new Form2();

            //Mostrando o segundo formulário Calculadora IMC
            form2.Show();
        }

        private void btnAbrir_FormaGeométrica_Click(object sender, EventArgs e)
        {
            //Criando uma instância do segundo formulário
            Form3 form3 = new Form3();

            //Mostrando o terceiro formulário Forma Geométrica
            form3.Show();
        }
    }
}
