using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_ComB_Grupo4
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        public string Titulo
        {
            get { return this.titulo; }
        }

        public override string ToString()
        {
            return "El libro es: " + titulo + " del autor " + autor + " y editorial " + editorial; 
        }
    }
}
