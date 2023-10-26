using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConductores
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon1 = new Dragon();
            dragon1.presentarse();
            float velocidad = dragon1.calcVelocidadVuelo();
            Console.WriteLine("Velocidad" + velocidad);

            Dragon dragon2 = new Dragon("electrico", "amarillo");
            dragon2.presentarse();
            Console.WriteLine(
                "Velocidad:" + dragon2.calcVelocidadVuelo());

            Dragon dragon3 = new Dragon("roca", "blanco");
            dragon3.presentarse();

            Console.ReadLine();
            

        }
    }
}