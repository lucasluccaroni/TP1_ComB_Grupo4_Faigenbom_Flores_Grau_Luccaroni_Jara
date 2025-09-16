using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_ComB_Grupo4
{
    internal class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
           libros = new List<Libro>();
        }

        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while(i < libros.Count && !libros[i].Titulo.Equals(titulo))
            {
                i++;
            }
            if(i != libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado;
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = this.buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void listarLibros()
        {
            foreach(var libro in libros)
            {
                Console.WriteLine(libro);
            }
        }

        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libroAEliminar = null;
            libroAEliminar = buscarLibro(titulo);
            if(libroAEliminar != null)
            {
                libros.Remove(libroAEliminar);
                resultado = true;
            }
            return resultado;

                


        }
        
    }
}
