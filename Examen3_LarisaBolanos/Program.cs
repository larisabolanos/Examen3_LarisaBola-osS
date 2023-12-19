using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3_LarisaBolanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float edad;
            string correo;
            string partido;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("cuantos años tienes?", nombre);
            edad = float.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("eres mayor de edad");
            else
                Console.WriteLine("eres menor de edad");

            nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu correo electronico");
            correo = Console.ReadLine();
            Console.WriteLine("Escribe el partido PLN,PAC,PUSC  ");
            partido = Console.ReadLine();
           Console.WriteLine("Por favor introduzca su edad");
           
           
        }
        public Encuesta()
        {
            // 3 rangos de encuesta:
            rangosEncuesta = new RangoEncuesta[3];

            rangosEncuesta[0] = new RangoEncuesta();
            rangosEncuesta[1] = new RangoEncuesta();
            rangosEncuesta[2] = new RangoEncuesta();
        }
    }



        }
    

