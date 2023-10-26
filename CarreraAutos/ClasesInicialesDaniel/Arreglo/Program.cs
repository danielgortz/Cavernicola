using System;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
               
           string[] diasSemana = {"Domingo","Lunes","Martes","Miercoles","Jueves","Viernes","Sabado"};

            int canDias = diasSemana.Length;

            Console.WriteLine(
                "Hay" + canDias + " dias en el arreglo.");
                //asignar un valor en el arreglo
                diasSemana[1] = "Monday";
            //accedo a un elemento y lo
            //guardo en variable
                string diaUno = diasSemana[1];
                string diaTres = diasSemana[3];

            Console.WriteLine(diaUno);
            Console.WriteLine(diaTres);
            //accedo a un elemento y lo uso directamente 

            Console.WriteLine(diasSemana[0]);
            Console.WriteLine(diasSemana[4]);

            for(int i = 0; i < diasSemana.Length; i++)//Parametrizado

            {
                //Uso la var de control i para 
                //acceder a cada elemento del arreglo
                Console.WriteLine(i + ".-" + diasSemana[i]);
            }




            Console.ReadLine();

        }
    }
}
