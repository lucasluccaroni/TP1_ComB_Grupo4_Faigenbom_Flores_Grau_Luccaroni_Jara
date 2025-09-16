using System;

namespace TP1_ComB_Grupo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca laBiblioteca = new Biblioteca();
            cargarLibros(10);
            Console.WriteLine("--- --- ---");
            cargarLibros(2);
            Console.WriteLine("--- --- ---");
            laBiblioteca.listarLibros();
            laBiblioteca.eliminarLibro("Titulo5");
            Console.WriteLine("--- --- ---");
            laBiblioteca.listarLibros();

            void cargarLibros(int cantidad)
            {
                bool pude;
                int i;
                for(i = 1; i <= cantidad; i++)
                {
                    pude = laBiblioteca.agregarLibro("Titulo" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
                    {
                        Console.WriteLine("Libro" + i + " agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Libro" + i + " ya existe en la biblioteca.");
                    }
                }
            }
        }
    }
}
