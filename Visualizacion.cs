/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 23/8/2026
 * Time: 19:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Trabajo1_Complejidad;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Visualizacion.
	/// </summary>
	//Ejercicio 2
	public class Visualizacion: Comparable
	{
		private int cantidad;
		
		public Visualizacion(int c) { this.cantidad=c;}
		
		public int getCantidad{ get{return cantidad;} }
		
		public bool sosIgual (Comparable comp) {
			Visualizacion otro= (Visualizacion)comp;
			return cantidad.CompareTo(otro.cantidad)==0;
		}
		
		public bool sosMenor (Comparable comp) {
			Visualizacion otro= (Visualizacion)comp;
			return cantidad.CompareTo(otro.cantidad)<0;
		}
		
		public bool sosMayor (Comparable comp) {
			Visualizacion otro= (Visualizacion)comp;
			return cantidad.CompareTo(otro.cantidad)>0;
		}
		
		public override string ToString() { return cantidad.ToString(); }

	}
}
