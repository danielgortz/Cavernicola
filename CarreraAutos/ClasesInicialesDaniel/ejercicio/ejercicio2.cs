/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad; //Declaración de atributo Edad dentro de clase Elefante
        public float Peso; //Declaración de atributo Peso dentro de clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método Comer
        public void Comer(string comida)
        {

            for (int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }

        public void Rugir() //Declaración de metodo Rugir dentro de espacio de nombres Ejemplos
        {
            int distanciaEscuchante = 100; //Declaración de variable local distanciaElefante dentro de método Rugir
            Console.WriteLine($"{Nombre} está rugiendo.");
        }

        public void Dormir(int horas) //Declaración de método Dormir dentro de clase Elefante
                                      //Declaración de parámetro horas dentro de método Dormir
        {
            if (horas > 10) //Bloque condicional if dentro de método Dormir
            {
                float energiaGanada = 15; //Declaración de variable local energiaGanada dentro de bloque condicional if
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero //Declaración de clase Zapatero dentro de espacio de nombre Ejemplos
    {
        public string Nombre; //Declaración de atributo Nombre dentro de clase Zapatero
        public string Especialidad; //Declaración de atributo Especialidad dentro de clase Zapatero
        public int AñosExperiencia;//Declaración de atributo AñosExperiencia dentro de clase zapatero

        public void RepararZapatos(string tipo, int cantidad) //Declaración de método RepararZapato dentro de clase Zapatero
                                                              //Declaracón de parámetros tipo, cantida dentro de método RepararZapatos
        {
            int precio = 50; //Declaración de variable local precio dentro de método RepararZapato
            if (tipo == "tenis")  //Bloque condicional if dentro de método RepararZapato
            {
                precio = 100;//Declaración de variable local precio dentro de bloque condicional if
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }

        public void CrearZapato(string estilo, string material)//Declaración de método CrearZapato dentro de clase Zapatero
                                                               //Declaraciòn de parámetros estilo, material dentro de método CrearZapato
        {
            for (int i = 0; i < 100; i++) //Ciclo for dentro de método CrearZapato
            {
                if (estilo == "industrial") //Bloque condicional if dentro de Ciclo for
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else //Bloque condicional else dentro de Ciclo for
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }

        public void MedirPie(int numeroPie) //Declaración de método Medir pie dentro de clase Zapatero
                                            //Declaración de parámetro numeroPie dentro de método MedirPie
        {
            string cliente; //Declaración de variable local Cliente dentro de método MedirPie
            if (numeroPie > 20) //Bloque condicional if dentro de método MedirPie
            {
                cliente = "Adulto"; //Uso de variable local cliente dentro de bloque condicional if MUY IMPÒRTANTE CUANDO ES DECLARACIÓN Y USO 
            }
            else //Bloque condicional else dentro de método MedirPie
            {
                cliente = "Niño";//Declaración de variable local cliente dentro de bloque condicional else
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    class Television //Delcaración de clase Televisión dentro de espacio de nombre Ejemplos
    {
        public string Marca; //Declaración de atributo Marca dentro de clase Televisión
        public int Pulgadas; //Declaración de atributo Pulgadas dentro de clase Televisión
        public bool Encendida; //Declaración de atributo Enendida dentro de clase Televisióm

        public void Encender() //Declaración de método Encender dentro de classe Televisión
        {
            Encendida = true; //Declaración de varibable local dentro de método Encender
            float consumoLuz = 0.05f; //Delcaración de variable local dentro de método Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        public void CambiarCanal(int canal) //Declaración de Método CambiarCanal dentro de clase Televisión
                                            //Declaración de parámetro canal dentro de método CambiarCanaal
        {
            for (int i = 1; i < canal; i++)//Ciclo for dentro de método CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }
        }

        public void AjustarVolumen(int nivel) //Declaración de método AjustarVolumen dentro de clase Televisión
        {
            if (nivel > 100)//Bloque condicional if dentro de método AjustarVolumen
            {
                nivel = 0;//Declaración de variable locar nivel dentro de bloque condicional if
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra //Declaración de clase guitarra dentro de espacio de nombre Ejemplos
    {
        public string Marca; //Declaración de atributo Marca dentro de clase Guitarra
        public string Tipo; //Declaración de atributo Tipo dentro de clase Guitarra
        public int Cuerdas; //Declaración de atributo Cuerdas dentro de clase guitarra

        public void TocarCuerda(int numeroCuerda) //Declaración de método TocarCuerda dentro de clase Guitarra
                                                  //Delcaración de parámetro numeroCuerda dentro de método TocarCuerda
        {
            if (numeroCuerda == 6) //Bloque condicional if dentro de método TocarCuerda
            {
                string nota = "Mi"; //Declaración de variable local nota dentro de bloque condicional if
            }
            else if (numeroCuerda == 5) //Bloque condicional else if dentro de método TocarCuerda
            {
                string nota = "La"; //Declaracion de variable local nota dentro de bloque condicional else if
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        public void AfinarGuitarra(bool afinada) //Declaración de método AfinarGuitarra dentro de clase Guitarra
        //Declaración de parámetro afinada dentro de método AfinarGuitarra
        {
            if (afinada) //Bloque condicional if dentro de método AfinarGuitarra
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else //Bloque condicional else dentro de método AfinarGuitarra
            {
                for (int i = 0; i < 5; i++) //Ciclo for dentro de bloque condicional else
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }
            }
        }

        public void CambiarTipo(string nuevoTipo) //Declaración de método CambiarTipo
                                                  //Declaraciòn de parámetro nuevoTipo
        {
            Tipo = nuevoTipo; //Declaración de variable local nuevoTipo
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}