using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02
{
    class Program
    {
        static void Main(string[] args)
        {
            double pxh, ht, htt, pb, pbt, pi, pe = 0, pn;
            string nombre, te;
            Console.WriteLine("Nombre del empleado?");
            nombre = Console.ReadLine();
            Console.WriteLine("Pago por hora?");
            pxh = double.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabajadas?");
            ht = double.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de estacionamiento (A,B,Ninguno)?");
            te = Console.ReadLine();
            if (ht > 40)
            {
                htt = ht - 40;
                pbt = pxh * 40;
                pb = (htt * (pxh * 2)) + pbt;
                pi = pb * 0.13;
                if (pb < 1000)
                {
                    if (te.ToUpper() == "A")
                    {
                        pe = 5;
                    }
                    else if (te.ToUpper() == "B")
                    {
                        pe = 2;
                    }
                }
                else
                {
                    if (te.ToUpper() == "A")
                    {
                        pe = 7;
                    }
                    else if (te.ToUpper() == "B")
                    {
                        pe = 3;
                    }
                }
                pn = pb - (pe + pi);
                Console.WriteLine("{0}, recibe un pago por hora de {1}\nEsta semana trabajo {2} horas\nUtilizo esta semana el estacionamiento tipo {3}\n", nombre, pxh, ht, te);
                Console.WriteLine("El resumen de sus pagos es\nPaga Bruta: ${0}\n-Pago por impuestos: ${1}\n-Pago por estacionamiento: ${2}\nPaga Neta: ${3}", pb, pi, pe, pn);
            }
            else
            {
                pb = pxh * ht;
                pi = pb * 0.13;
                if (pb < 1000)
                {
                    if (te.ToUpper() == "A")
                    {
                        pe = 5;
                    }
                    else if (te.ToUpper() == "B")
                    {
                        pe = 2;
                    }
                }
                else
                {
                    if (te.ToUpper() == "A")
                    {
                        pe = 7;
                    }
                    else if (te.ToUpper() == "B")
                    {
                        pe = 3;
                    }
                }
                pn = pb - (pe + pi);
                Console.WriteLine("{0}, recibe un pago por hora de {1}\nEsta semana trabajo {2} horas\nUtilizo esta semana el estacionamiento tipo {3}\n", nombre, pxh, ht, te);
                Console.WriteLine("El resumen de sus pagos es\nPaga Bruta: ${0}\n-Pago por impuestos: ${1}\n-Pago por estacionamiento: ${2}\nPaga Neta: ${3}", pb, pi, pe, pn);
            }
        }
    }
}
