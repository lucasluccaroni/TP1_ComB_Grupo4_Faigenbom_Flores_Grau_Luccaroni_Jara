using System;

namespace TP1_ComB_Grupo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca laBiblioteca = new Biblioteca();

            Console.WriteLine("--- Cargamos 10 libros en la biblioteca ---");
            cargarLibros(10);
            Console.WriteLine("\n--- Intentamos cargar dos libros ya existentes ---");
            cargarLibros(2);
            Console.WriteLine("\n--- Listamos los libros cargados ---");
            laBiblioteca.listarLibros();
            laBiblioteca.eliminarLibro("Titulo5");
            Console.WriteLine("\n--- Listamos nuevamente los libros luego haber eliminado el Titulo5 ---");
            laBiblioteca.listarLibros();

            Console.WriteLine("\n--- Cargamos 5 lectores ---");
            cargarLectores(5);
            Console.WriteLine("\n--- Intentamos cargar dos lectores ya existentes ---");
            cargarLectores(2);

            Console.WriteLine("\n--- Prestamos ---");
            // Caso exitoso 1, usuario 4
            string prestamoUno = laBiblioteca.prestarLibro("Titulo9", 4);
            Console.WriteLine(prestamoUno);

            // Caso error, el libro no existe (ya fue prestado)
            string prestamoDos = laBiblioteca.prestarLibro("Titulo9", 3);
            Console.WriteLine(prestamoDos);

            // Caso error, el usuario no existe
            string prestamoTres = laBiblioteca.prestarLibro("Titulo3", 6);
            Console.WriteLine(prestamoTres);

            // Caso exitoso 2, usuario 4
            string prestamoCuatro = laBiblioteca.prestarLibro("Titulo8", 4);
            Console.WriteLine(prestamoCuatro);

            // Caso exitoso 3, usuario 4
            string prestamoCinco = laBiblioteca.prestarLibro("Titulo7", 4);
            Console.WriteLine(prestamoCinco);

            // Caso error, el usuario llegó al tope de prestamos
            string prestamoSeis = laBiblioteca.prestarLibro("Titulo6", 4);
            Console.WriteLine(prestamoSeis);

            Console.WriteLine("\n--- Listamos nuevamente los libros que quedan en la biblioteca ---");
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

            void cargarLectores(int cantidad)
            {
                bool pude;
                int i;
                for(i = 1; i <= cantidad; i++)
                {
                    pude = laBiblioteca.altaLector("Nombre" + i, "Apellido" + i, i);
                    if (pude)
                    {
                        Console.WriteLine("Usuario" + i + " registrado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Usuario" + i + " ya existe en el sistema.");
                    }
                }
            }


        }       
    }
}
