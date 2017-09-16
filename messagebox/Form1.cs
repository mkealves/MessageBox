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

        private void txbSalario_KeyPress(object sender, KeyPressEventArgs e)
            //VERIFICAÇÃO DE ENTRADA DO TECLADO, PERMITINDO APENAS ALGUMAS ENTRADAS
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            //char.isdigit(e.keychar) ele vai permitir apenas números e e.keychar != (char)8 apenas o backspace
            {
                e.Handled = true;
            }
        }

        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txbSNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
                //char.isletter(e.keychar) ele vai permitir apenas letras e e.keychar != (char)8 apenas o backspace
            {
                e.Handled = true;
            }
        }

        private void txbIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            //char.isdigit(e.keychar) ele vai permitir apenas números e e.keychar != (char)8 apenas o backspace
            {
                e.Handled = true;
            }
        }
    }
}
