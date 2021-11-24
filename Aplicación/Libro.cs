using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicación
{
    class Libro
    {
        private string titulo;
        private string autor;
        private string páginas;
        private string edición;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Páginas { get => páginas; set => páginas = value; }
        public string Edición { get => edición; set => edición = value; }
    }
}
