using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras ferrari = new AutoCarreras();
            ferrari.modelo = "Ferrari F150";
            ferrari.peso = 1.3f;
            ferrari.velocidad = 230;

            AutoCarreras RedBull = new AutoCarreras();
            RedBull.modelo = "RB19";
            RedBull.peso = 1.1f;
            RedBull.velocidad = 340;

            PistaCarreras hnsRodriguez = new PistaCarreras();
            hnsRodriguez.nombre= "Autodromo Hermanos Rogriguez";
            hnsRodriguez.longitud = 5.6f; 

            //Mando a competir a mis coches
            hnsRodriguez.competir(ferrari, RedBull);

            //le pongo 201 de gas al ferrari
            ferrari.PonerGas(20);
            ferrari.Arrancar();
            RedBull.Arrancar();

            ferrari.Acelerar(260);
            RedBull.Acelerar(280);

            ferrari.Arrancar();
            RedBull.Arrancar();

            //Esta instruccion espera a que des enter
            // para continuar
            Console.ReadLine();


        }
    }
}
