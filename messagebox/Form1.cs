using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string sobrenome = txbSNome.Text;
            int idade = Convert.ToInt32(txbIdade.Text);
            double salario = Convert.ToDouble(txbSalario.Text);
            double nsalario;

            if (idade <= 18)
            {
                nsalario = (salario * 0.1) + salario;
                MessageBox.Show(nome +" "+ sobrenome + "\nO seu aumento é de 10%\nO seu salário atual é de "+salario+" passou a ser "+nsalario);
            }
            else if (idade > 18 && idade <= 25)
            {
                nsalario = (salario * 0.12) + salario;
                MessageBox.Show(nome + " " + sobrenome + "\nO seu aumento é de 12%\nO seu salário atual é de " + salario + " passou a ser " + nsalario);
            }
            else if (idade > 25)
            {
                nsalario = (salario * 0.15) + salario;
                MessageBox.Show(nome + " " + sobrenome + "\nO seu aumento é de 15%\nO seu salário atual é de " + salario + " passou a ser " + nsalario);
            }

        }
    }
}
