using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appbliliotk
{
    public partial class Form1 : Form
    {
        Biblioteca LOGIN;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text!="") && (txtContraseña.Text!=""))
            {
                if ((txtUsuario.Text == "Maryeri") && (txtContraseña.Text == "1234"))
                {
                    LOGIN = new Biblioteca();
                    LOGIN.ShowDialog();
                    this.Hide();
                }
                if ((txtUsuario.Text == "Mariana") && (txtContraseña.Text == "1234"))
                {
                    LOGIN = new Biblioteca();
                    LOGIN.ShowDialog();
                    this.Hide();
                }
                if ((txtUsuario.Text == "Isabela") && (txtContraseña.Text == "1234"))
                {
                    LOGIN = new Biblioteca();
                    LOGIN.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("FAVOR RECTIFICAR DATOS");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
