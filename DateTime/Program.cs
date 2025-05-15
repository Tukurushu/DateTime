using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame fecha dd/MM/yyyy: ");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Tu fecha es: {fecha}");
            Console.WriteLine($"Tu fecha sin hora es: {fecha.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Tu fecha introducida corta es: {fecha.ToString("dd/MM/yy")}");
            DateTime fechaactual = DateTime.Now;
            DateTime fechahoy = DateTime.Today;

            Console.WriteLine($"Fecha actual: {fechaactual}");
            Console.WriteLine($"Fecha hoy: {fechahoy}");

            Console.WriteLine("Dame usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Dame contraseña");
            string password = Console.ReadLine();
            Console.WriteLine("Dame fecha nacimiento");
            DateTime fechanacimiento = Convert.ToDateTime(Console.ReadLine());
            //2025-1992//
            int edad= fechaactual.Year - fechanacimiento.Year;

            if (usuario == "Oscar" && password == "123" && edad >= 18)
            {
                Console.WriteLine($"Cumples los requisitos");
            }
            else
            {
                Console.WriteLine("No cumples los requisistos");
            }


            Console.ReadKey();
        }
    }
}
