using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace poo2
{
    public class EstudianteBecado : Estudiante
    {
        public string TipoBeca { get; set; }

        // Constructor con parámetros
        public EstudianteBecado(string nombre, int edad, string carrera, string tipoBeca)
            : base(nombre, edad, carrera)
        {
            TipoBeca = tipoBeca;
        }
        // Polimorfismo: redefinimos MostrarInfo
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {this.GetNombre()}, Edad: {Edad}, Carrera: {this.GetCarrera}, Beca: {TipoBeca}");
        }
        // Override: redefinimos otra vez
        public override decimal CalcularPago() 
        { 
            decimal pagoBase = base.CalcularPago();
            return pagoBase * 0.5m; // paga la mitad por la beca
        }
    }
}
