/*
INSTRUCCIONES

1. En cada una de las líneas del siguiente código
deberás colocar un comentario al final de la línea en el que 
indiques  el nivel de identación de la siguiente manera: //Identacion: #
donde # es el nivel de identación.

2. Adicional al nivel de identación, en cada línea donde 
haya una llave de apertura deberás colocar un comentario 
que diga: //Inicio de bloque ... 
donde los 3 puntos indican a qué le pertenece, por ejemplo:
inicio de bloque de metodo1, inicio de bloque de claseA, 
inicio de ciclo for, etc.
Y, donde haya una llave de cierre, deberás colocar lo mismo, 
pero indicando //Fin de bloque ...

Observa algunas líneas de ejemplo que ya lo tienen.
Debes hacerlo para cada una de las líneas, excepto las que 
estén vacías.
*/
using System; //identacion:0

namespace ClasesYMetodosAnidados //identacion:0
{// Inicio de bloque de namespace ClasesYMetodosAnidados //identacion:0
	class Program //Identacion: 5 //identacion:1
	{//Inicio de bloque de class//identacion:1
		static void Main(string[] args) //identacion:2
		{//Inicio de bloque de Main //identacion:2
			ClaseA objetoA = new ClaseA();//Identacion: 3
			ClaseB objetoB = new ClaseB();//identacion:3

			objetoA.Metodo1();//identacion:3
			objetoA.Metodo2();//identacion:3

			objetoB.Metodo1();//identacion:3
			objetoB.Metodo2();//identacion:3
		}//Fin de bloque de Main,identacion:3
	}//Fin de bloque de class,identacion:1

	class ClaseA //identacion:1
	{//Inicio de bloque ClaseA,identacion:1
		public void Metodo1()//identacion:2
		{//Inicio de bloque Metodo1,identacion:2
			for (int i = 0; i < 3; i++)//identacion:3
			{//Inicio de bloque de ciclo for,identacion:3
				Console.WriteLine("Método 1 de ClaseA - Iteración: " + i);//identacion:4

				for (int j = 0; j < 2; j++)//identacion:4
				{//Inicio de bloque Console,identacion:4
					Console.WriteLine("Ciclo anidado - Iteración: " + j);//identacion:5
				}//Fin de bloque Console,identaion:4
			}//Fin de bloque de ciclo for,identacion:3
		}//Fin de bloque Metodo1,identacion:2

		public void Metodo2()//identacion:2
		{//Inicio de bloque Metodo2,identacion:2
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)//identacion:3
			{//Inicio de bloque de ciclo if,identacion:3
				Console.WriteLine("Es fin de semana en Método 2 de ClaseA");//identacion:4
			}//Fin de bloque de ciclo if,identacion:3
			else//identacion:3
			{//Inicio de bloque ciclo else,identacion:3
				Console.WriteLine("No es fin de semana en Método 2 de ClaseA");//identacion:4
			}//Fin de bloque ciclo else,identacion:3
		}//Fin de bloque Metodo 2,identacion:2
	}//Fin de bloque ClaseA,identacion:1

	class ClaseB //identacion:1
	{//Inicio de bloque ClaseB,identacion:1
		public void Metodo1()//identacion:2
		{//Incio de bloque Metodo1,identacion:2
			for (int i = 5; i > 0; i--)//identacion:3
			{//Inicio de bloque de ciclo for,identacion:3
				Console.WriteLine("Método 1 de ClaseB - Iteración: " + i);//identacion:4

				for (int j = 0; j < i; j++)//identacion:4
				{//inicio de bloque de ciclo if,identacion:4
					Console.WriteLine("Ciclo anidado - Iteración: " + j);//identacion:4
				}//fin de bloque de ciclo if,identacion:4
			}//fin de bloque de ciclo for,identacion:3
		}//Fin de bloque Metodo1,identacion:2

		public void Metodo2()//identacion:2
		{//Inicio de bloque Metodo2,identacion:2
			int numero = 10;//identacion:3

			if (numero % 2 == 0)//identacion:3
			{//inicio de bloque de ciclo if,identacion:3
				Console.WriteLine("El número es par en Método 2 de ClaseB");//identacion:4
			}//fin de bloque de ciclo if,identacion:3
			else//identacion:3
			{//inicio de bloque de ciclo if,identacion:3
				Console.WriteLine("El número es impar en Método 2 de ClaseB");//identacion:4
			}//fin de bloque de ciclo if,identacion:3
		}//Fin de bloque Metodo2,identacion:2
	}//Fin de bloque ClaseB,identacion:1
}//Fin de bloque de namespace ClasesyMetodosAnidados//identacion:0

