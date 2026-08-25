/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 23/8/2026
 * Time: 19:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Program.
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{	
			/*
            Coleccionable cola= new Cola();
            Coleccionable pila= new Pila();
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);
			*/
			
			/*
			Pila p= new Pila();
			Cola c= new Cola();
			Catalogo cat=new Catalogo(p,c);
			llenar(p);
			llenar(c);
			informar(p);
			informar(c);
			informar(cat);
			*/
			
			
			Pila p=new Pila();
			Cola c= new Cola();
			Catalogo cat= new Catalogo(p, c);
			llenarSuscriptores(p);
			llenarSuscriptores(c);
			informar(cat);
			

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
		
		//Ejercicio 5
		public static void llenar(Coleccionable coleccion)
		{
			Random random= new Random();
			for(int i=0; i<20; i++)
			{
				int cantidad= random.Next(1,100);
				Comparable c= new Visualizacion(cantidad);
				coleccion.agregar(c);
			}
		}
		
		//Ejercicio 6
		public static void informar(Coleccionable coleccion)
		{
			Console.WriteLine ("cantidad de elementos: {0}", coleccion.cuantos());
			Console.WriteLine ("minimo: {0}", coleccion.minimo());
			Console.WriteLine ("maximo: {0}", coleccion.maximo());
			Console.WriteLine ("Ingrese un valor para verificar si esta en la coleccion: ");
			int valor=int.Parse(Console.ReadLine());
			Comparable c= new Visualizacion(valor);
			if(coleccion.contiene(c))
				Console.WriteLine("El elemento leido esta en la coleccion");
			else
				Console.WriteLine("El elemento leido no esta en la coleccion");
		}
		
		//Ejercicio 12
		public static void llenarSuscriptores(Coleccionable coleccion)
		{
			string[] nombres= {"Luna", "Julieta", "Mauro","Omar", "Tiago", "Veronica", "Pilar", "Gisella", "Enrique", "Maria", "Fausto"};
			Random random= new Random();
			for(int i=0; i<20; i++)
			{
				int id= random.Next(1,1000);
				int horas= random.Next(200, 1500);
				int meses=random.Next(1,12);
				string nombre= nombres[random.Next(nombres.Length)];
				Comparable c=new Suscriptor(nombre, id, meses, horas);
				
				coleccion.agregar(c);
			}
		}
		
	}
}
