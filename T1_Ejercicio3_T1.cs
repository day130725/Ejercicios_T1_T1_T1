using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese el sueldo del empleado: ");
                double suel = Convert.ToDouble(Console.ReadLine());
                double impues = 0;
                double suelNeto = suel;
                if (suel <= 1500)
                {
                    impues = suel * 0.10; 
                    suelNeto = suel - impues;
                }
                else
                {
                    if (suel <= 3000)
                    {
                        impues = (suel - 1500) * 0.05; 
                        suelNeto = suel - impues;
                    }
                    else

                    {
                        impues = (suel - 3000) * 0.03; 
                        suelNeto = suel - impues;
                    }
                }
                Console.WriteLine("El impuesto a descontar es: " + impues);
                Console.WriteLine("El salario neto es: " + suelNeto);

            }


        }
    }
}
