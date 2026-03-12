using System;
using System.Collections.Generic;

namespace poo2
{
    public class Program
    {
        // Colecciones accesibles en toda la clase
        static List<Persona> personas = new List<Persona>();
        static Queue<Persona> colaAtencion = new Queue<Persona>();
        static Stack<Persona> historialAtendidos = new Stack<Persona>();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n --- MENÚ DEL ESTUDIANTE ---");
                Console.WriteLine("1. Agregar un estudiante");
                Console.WriteLine("2. Listar los estudiantes actuales");
                Console.WriteLine("3. Buscar estudiante por cédula");
                Console.WriteLine("4. Filtrar estudiante por edad (LINQ)");
                Console.WriteLine("5. Atender estudiante (Queue)");
                Console.WriteLine("6. Registrar estudiante atendido (Stack)");
                Console.WriteLine("7. Salir");
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarEstudiante(); break;
                    //case "2": ListarEstudiantes(); break;
                    //case "3": BuscarPorCedula(); break;
                    //case "4": FiltrarPorEdad(); break;
                    //case "5": AtenderEstudiante(); break;
                    //case "6": RegistrarAtendido(); break;
                    case "7": salir = true; break;
                    default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
                }
            }
        }

        // Agregar estudiante
        public static void AgregarEstudiante()
        {
            Console.Write("¿Es un estudiante becado? (s/n): ");
            string esBecado = Console.ReadLine().ToLower();
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del estudiante: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la carrera del estudiante: ");
            string carrera = Console.ReadLine();

            Persona nuevo;
            if (esBecado == "s")
            {
                Console.Write("Ingrese el tipo de beca: ");
                string tipoBeca = Console.ReadLine();
                nuevo = new EstudianteBecado(nombre, edad, carrera, tipoBeca);
            }
            else
            {
                nuevo = new Estudiante(nombre, edad, carrera);
            }

            personas.Add(nuevo);
            colaAtencion.Enqueue(nuevo);
            Console.WriteLine("Estudiante agregado correctamente.");
        }
    }
}
