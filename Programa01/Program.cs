using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            double angcon, angf;
            Console.Clear();
            Console.WriteLine("Angulo original en R o G");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "R")
            {
                Console.WriteLine("\nAngulo a convertir ");
                angcon = double.Parse(Console.ReadLine());
                angf = (Math.PI / 180) * angcon;
                Console.WriteLine("{0} Radianes equivalen a {1} Grados", angcon, angf);
            }
            else if (resp.ToUpper() == "G")
            {
                Console.WriteLine("\nAngulo a convertir ");
                angcon = double.Parse(Console.ReadLine());
                angf = (180 / Math.PI) * angcon;
                Console.WriteLine("{0} Grados equivalen a {1} Radianes", angcon, angf);
            }
            else
            {
                Console.WriteLine("No se reconoce el sistema a convertir");
            }
        }
    }
}
