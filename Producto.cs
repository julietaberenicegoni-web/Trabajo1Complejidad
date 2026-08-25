/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 23/8/2026
 * Time: 17:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	//Ejercicio 1
	public class Producto: Comparable
	{
		private string nombre;
		private int precio;
		
		public Producto(string nombre, int precio) {
			this.nombre=nombre;
			this.precio=precio;
		}
		
		public string Nombre {
			get{return nombre;}
			set{nombre=value;}
		}
		public int Precio {
			get{return precio;}
			set{precio=value;}
		}
		
		public bool sosIgual(Comparable comp) {
			Producto otro= (Producto)comp;
			return this.precio.CompareTo(otro.precio)==0;
		}
		public bool sosMenor(Comparable comp) {
			Producto otro= (Producto)comp;			
			return this.precio.CompareTo(otro.precio)<0;
		}
		
		public bool sosMayor(Comparable comp) {
			Producto otro= (Producto)comp;			
			return this.precio.CompareTo(otro.precio)>0;
		}
		
		public override string ToString() { return nombre + " " + precio; }
	}
}
