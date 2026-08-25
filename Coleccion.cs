/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 23/8/2026
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Coleccion.
	/// </summary>
	public class Coleccion: Coleccionable
	{
		private List<Comparable> elementos;
		
		public Coleccion() { this.elementos= new List<Comparable>(); }
		
		public int cuantos () { return elementos.Count; }
		
		public Comparable minimo (){
			Comparable menor= elementos[0];
			foreach(Comparable c in elementos){
				if(c.sosMenor(menor))
					menor=c;
			}
			return menor;
		}
		
		public Comparable maximo (){
			Comparable mayor=elementos[0];
			foreach(Comparable c in elementos){
				if(c.sosMayor(mayor))
					mayor=c;
			}
			return mayor;		
		}
		
		public void agregar (Comparable elem) { elementos.Add(elem); }
		
		public bool contiene (Comparable elem){
			foreach(Comparable c in elementos){
				if (elem.sosIgual(c))
					return true;
			}
			return false;
		}
				
		}
	}
