using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class AutoCarreras

    {
        public string modelo;
        public float peso;
        public int velocidad;
        public float gasolina;

        public void PonerGas(float cantidad)
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine(
                modelo + "tiene"
                + gasolina + "1 de gas");

        }

        public void Acelerar(int aceleracion )

        {
            //metodo acelerar disminuir la gasolina y si la gasolina llega a 0 mandar mensaje
            gasolina = gasolina - velocidad / 10f;
            velocidad = velocidad + aceleracion;

            if (gasolina < 0)
            {
                Console.WriteLine(modelo + "sin combustible");

            }

            else
            {
                Console.WriteLine(modelo + "sin energia" + velocidad + " estoy fuera chicos");
            }
        }

        

        public void Frenar()
        {
            if (velocidad > 0)
            {
                velocidad = 0;
                Console.WriteLine(modelo + "a frenado");

            }
            else
            {
                Console.WriteLine(modelo + "y esta frenado");
            }
        }





        public void Arrancar()
        {
            if (gasolina > 0)
            {
                //Consume 0.01 litrosde
                //gas cada que arranca
                gasolina = 0.01f;
                Console.WriteLine("Arrancando" + modelo + "le quedan" + gasolina + "1 de gas");
            }
            else
            {
                Console.WriteLine(
             "No se puede arrancar"
             + modelo + " sin gasolina");
            }


        }





    }    
}          
   

      
