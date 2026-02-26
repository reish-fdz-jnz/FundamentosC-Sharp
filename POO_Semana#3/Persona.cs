using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo2
{
    public abstract class Persona
    {
        // Atributos privados
        private string Nombre;

        // Encapsulamiento con Propiedads
        public int Edad { get; set; }

        // Constructor sin parámetros
        public Persona() 
        {
            this.Nombre = "Juan";
        }
        // Constructor con parámetros
        public Persona(string nombre, int edad) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public void SetNombre(string nuevoNombre)
        {
            this.Nombre = nuevoNombre;
        }
        public string GetNombre() 
        {
            return this.Nombre;
        }

        //Abstracto: Método sin implementación que debe ser implementado por las clases derivadas
        public abstract void MostrarInfo();

        // Método virtual: puede ser redefinido
        public virtual decimal CalcularPago() 
        { 
            return 1000; // tarifa general
        }
    }
}
