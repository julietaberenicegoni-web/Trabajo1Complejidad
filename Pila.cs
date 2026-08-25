/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 23/8/2026
 * Time: 21:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila: Coleccionable
	{
		private List<Comparable> elementos;

		public Pila(){ elementos = new List<Comparable>(); }
		
		public List<Comparable> Elementos { get {return elementos;} }

		public void Apilar(Comparable elem) { elementos.Add(elem); }

		public Comparable Desapilar()
		{
			Comparable elem = elementos[elementos.Count - 1];
			elementos.RemoveAt(elementos.Count - 1);
			return elem;
		}

		public bool EstaVacia() { return elementos.Count == 0;}

		public void agregar(Comparable elem) { Apilar(elem); }

		public bool contiene(Comparable elem)
		{
			foreach (Comparable elemento in elementos)
			{
				if (elemento.sosIgual(elem))
				{
					return true;
				}
			}

			return false;
		}

		public int cuantos() { return elementos.Count; }

		public Comparable minimo()
		{
			Comparable menor = elementos[0];

			foreach (Comparable elemento in elementos)
			{
				if (elemento.sosMenor(menor))
				{
					menor = elemento;
				}
			}

			return menor;
		}

		public Comparable maximo()
		{
			Comparable mayor = elementos[0];

			foreach (Comparable elemento in elementos)
			{
				if (elemento.sosMayor(mayor))
				{
					mayor = elemento;
				}
			}

			return mayor;
		}
	}
}                                              
