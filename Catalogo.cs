/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 24/8/2026
 * Time: 15:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Catalogo.
	/// </summary>
	public class Catalogo: Coleccionable
	{
		private Pila pila;
		private Cola cola;
		
		public Catalogo(Pila p, Cola c){
			this.pila=p;
			this.cola=c;
		}
		
		public int cuantos (){ return pila.cuantos()+ cola.cuantos();}
		public Comparable minimo (){
			Comparable min=pila.minimo();
			if(cola.minimo().sosMenor(min))
				min=cola.minimo();
			return min;
		}
		public Comparable maximo (){
			Comparable max=pila.maximo();
			if(cola.maximo().sosMayor(max))
				max=cola.maximo();
			return max;
		}
		
		public void agregar (Comparable elem){}
		
		public bool contiene (Comparable elem){
			if(pila.contiene(elem))
				return true;
			else if (cola.contiene(elem))
				return true;
			return false;
		}
	}
}
