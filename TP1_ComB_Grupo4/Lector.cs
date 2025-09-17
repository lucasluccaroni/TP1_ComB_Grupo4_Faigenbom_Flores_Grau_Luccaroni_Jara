using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_ComB_Grupo4
{
    internal class Lector
    {
        private string nombre, apellido;
        private int dni, nroPrestamos, limitePrestamos;
        private List<Libro> librosEnPrestamo;

        public Lector(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nroPrestamos = 0;
            this.limitePrestamos = 3;
            librosEnPrestamo = new List<Libro>();
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public bool prestamoDisponible()
        {
            bool resultado = false;
            int cantidadDisponible;
            cantidadDisponible = this.limitePrestamos - this.nroPrestamos;
            if((cantidadDisponible > 0) && (cantidadDisponible <= 3))
            {
                resultado = true;
            }
            return resultado;
        }

        public void añadirPrestamo(Libro libro)
        {
            librosEnPrestamo.Add(libro);
            nroPrestamos++;
        }
    }

}
