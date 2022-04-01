using System;

namespace ConsoleApplication1
{
    public class Empleado
    {
        //atributos
        private string nombre;
        private double salario;
        private string modalidad;
        private double isss;
        private double afp;
        private double renta;
        private bool genero; //true = masculino , false = femenino
        private int anioNacimiento;

        private double salarioFinal;

        //metodos
       public Empleado(string name, double salary, string mode, double isssDiscount, double afpDiscount, double rent, bool gender, int birth)
       {
           nombre = name;
           salario = salary;
           modalidad = mode;
           isss = isssDiscount;
           afp = afpDiscount;
           renta = rent;
           genero = gender;
           anioNacimiento = birth;
       }

       public double CalcularDeducciones()
       {
           if (modalidad == "servicio profesional")
           {
               salarioFinal = salario - (salario * renta);
               return Math.Round(salarioFinal, 2);
           }
           else
           {
               salarioFinal = salario - (salario * isss) - (salario * afp) - (salario * renta);
               return Math.Round(salarioFinal, 2);
           }
       }

       public bool CalcularRetiro()
       {
           if (genero == true && anioNacimiento >= 1962)
           {
               return true;
           }
           else if (genero == false && anioNacimiento <= 1967)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       
    }
}