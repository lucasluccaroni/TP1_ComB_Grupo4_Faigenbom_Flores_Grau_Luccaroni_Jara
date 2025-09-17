using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_ComB_Grupo4
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {

            libros = new List<Libro>();
            lectores = new List<Lector>();
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

        private Lector buscarLector(int dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while(i < lectores.Count && !lectores[i].Dni.Equals(dni))
            {
                i++;
            }
            if(i != lectores.Count)
            {
                lectorBuscado = lectores[i];
            }
            return lectorBuscado;
        }
        
        public bool altaLector(string nombre, string apellido, int dni)
        {
            bool resultado = false;
            Lector lector = this.buscarLector(dni);
            if(lector == null)
            {
                lector = new Lector(nombre, apellido, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        public string prestarLibro(string titulo, int dni)
        {   
            string resultado = null;
            string libroInexistente = "LIBRO INEXISTENTE.";
            string lectorInexistente = "LECTOR INEXISTENTE.";
            string topeDePrestamos = "TOPE DE PRESTAMO ALCANZADO.";
            string prestamoExitoso = "PRESTAMO EXITOSO.";
            Libro libroAPrestar = null;
            Lector lectorAPrestamo = null;

            // buscamos el libro
            libroAPrestar = buscarLibro(titulo);
            if (libroAPrestar == null)
            {
                resultado = libroInexistente;
                return resultado;
            }

            // buscamos el lector
            lectorAPrestamo = buscarLector(dni);
            if(lectorAPrestamo == null)
            {
                resultado = lectorInexistente;
                return resultado;
            }

            // Si existe el lector y el libro chequeamos la cantidad de prestamos del lector
            if((resultado != libroInexistente) && (resultado != lectorInexistente))
            {
                bool chequeoPrestamosDisponibles = lectorAPrestamo.prestamoDisponible();
                if (!chequeoPrestamosDisponibles)
                {
                    resultado = topeDePrestamos;
                    return resultado;
                }
            }
            // Está todo  ok, hacemos el prestamo.
            lectorAPrestamo.añadirPrestamo(libroAPrestar); // Agregamos el libro a la lista del lector
            libros.Remove(libroAPrestar); // Eliminamos el libro de la lista de la biblioteca
            resultado = prestamoExitoso;
            return resultado;
        }
    }
}
