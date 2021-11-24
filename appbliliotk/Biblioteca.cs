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
    
    public partial class Biblioteca : Form
    {
        private string[,] libroautor;
        private string [] busquedaLibro;
        private string LibroBuscado;
        private string AutorBuscado;

        public Biblioteca()
        {
            InitializeComponent();
            libroautor = new string[3, 3];
            busquedaLibro = new string[3];

            libroautor[0, 0] = "Cien años de soledad";
            libroautor[0, 1] = "Gabriel García Marquez";
            libroautor[0, 2] = "Zona de novelas";


            libroautor[1, 0] = "Blanca Nieves";
            libroautor[1, 1] = "Jacob Grimm";
            libroautor[1, 2] = "Zona de libros infantiles";

            libroautor[2, 0] = "Pensar Rápido";
            libroautor[2, 1] = "Daniel Kahneman";
            libroautor[2, 2] = "Zona de Psicología";

            
        }

        public string[,] Libroautor { get => libroautor; set => libroautor = value; }
        public string[] BusquedaLibro { get => busquedaLibro; set => busquedaLibro = value; }
        public string LibroBuscado1 { get => LibroBuscado; set => LibroBuscado = value; }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {           

            LibroBuscado = txtBuscarLibro.Text.ToLower(); 
          
            for (int f = 0; f < libroautor.GetLength(0); f++)
            {
                for (int c = 0; c < libroautor.GetLength(1); c++)
                {
                    
                    if (libroautor[f, c].ToLower().Contains(LibroBuscado))
                    {                        
                        busquedaLibro[c] = libroautor[f, c];
                        busquedaLibro[c + 1] = libroautor[f, c + 1];
                        busquedaLibro[c + 2] = libroautor[f, c + 2];
                    }
                }
            }          
            txtLibroEncontrado.Text = busquedaLibro[0];
            txtAutorEncontrado.Text = busquedaLibro[1];
            txtUbicación.Text = busquedaLibro[2];
        }
        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            AutorBuscado = txtBuscarAutor.Text.ToLower();

            for (int f = 0; f < libroautor.GetLength(0); f++)
            {
                for (int c = 0; c < libroautor.GetLength(1); c++)
                {

                    if (libroautor[f, c].ToLower().Contains(AutorBuscado))
                    {

                        busquedaLibro[c - 1] = libroautor[f, c - 1];
                        busquedaLibro[c] =    libroautor[f, c ];
                        busquedaLibro[c + 1] = libroautor[f, c + 1];
                        
                    }
                }
            }
            txtLibroEncontrado.Text = busquedaLibro[0];
            txtAutorEncontrado.Text = busquedaLibro[1];
            txtUbicación.Text = busquedaLibro[2];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtAutorEncontrado.Clear();
            txtBuscarAutor.Clear();
            txtBuscarLibro.Clear();
            txtLibroEncontrado.Clear();
            txtUbicación.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
