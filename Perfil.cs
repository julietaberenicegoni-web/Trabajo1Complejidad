/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 24/8/2026
 * Time: 16:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Perfil.
	/// </summary>
	public abstract class Perfil: Comparable
	{
		private string nombre;
		private int id;
		
		public Perfil(string nombre, int id)
		{
			this.nombre=nombre;
			this.id=id;
		}
		
		public string Nombre{ get{return nombre;} }		
		public int Id{ get{return id;} }
		
		public virtual bool sosIgual(Comparable elem){
			Perfil e=(Perfil)elem;
			return id.CompareTo(e.Id)==0;
		}
		
		public virtual bool sosMenor(Comparable elem){
			Perfil e=(Perfil) elem;
			return id.CompareTo(e.Id)<0;
		}
		
		public virtual bool sosMayor(Comparable elem){
			Perfil e=(Perfil)elem;
			return id.CompareTo(e.Id)>0;
			
		}
	}
}
