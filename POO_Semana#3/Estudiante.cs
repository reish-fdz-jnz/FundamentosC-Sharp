using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo2
{
    public class Estudiante : Persona
    {
        private string Carrera;

        public void SetCarrera(string nuevaCarrera)
        {
            this.Carrera = nuevaCarrera;
        }
        public string GetCarrera()
        {
            return this.Carrera;
        }
        public Estudiante(string nombre, int edad, string carrera) : base()
        {
            this.Carrera = carrera;
        }
        // Polimorfimo: Sobrescribir el método MostrarInfo() de la clase base Persona
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {this.GetNombre()}, Edad: {this.Edad}, Carrera: {this.Carrera}");
        }

        // Override: redefinimos el método
        public override decimal CalcularPago() 
        { 
            if (Carrera == "Medicina") 
                return 2000; 
            if (Carrera == "Ingeniería") 
                return 1500; 
            return 1200; 
        }
    }
}
