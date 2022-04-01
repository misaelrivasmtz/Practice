using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Empleado Persona1 = new Empleado("Alejandro", 1000, "planilla", 0.03, 0.07, 0.10, false, 1989);
            Console.WriteLine("El salario es: " + Persona1.CalcularDeducciones());
            if (Persona1.CalcularRetiro() == true)
            {
                Console.WriteLine("Usted es apto para el retiro"); 
            }
            else
            {
                Console.WriteLine("Usted no es apto para el retiro");
            }
        }
    }
}