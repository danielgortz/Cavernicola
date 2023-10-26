using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNombresVillanos
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneradorNombresVillanos generador =
                new GeneradorNombresVillanos();

            generador.generar(15);
            Console.Read();


        }
    }
}
