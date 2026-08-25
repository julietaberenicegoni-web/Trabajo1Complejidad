/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 24/8/2026
 * Time: 16:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Suscriptor.
	/// </summary>
	public class Suscriptor: Perfil
	{
		private int mesesDeSuscripcion;
		private int horasVistas;
		
		public Suscriptor(string nombre, int id, int mesesSus, int horasVis): base(nombre,id)
		{
			this.mesesDeSuscripcion=mesesSus;
			this.horasVistas=horasVis;
		}
		
		public int getMesesDeSuscripcion { get{return mesesDeSuscripcion;} }
		public int getHorasVistas{ get{return horasVistas;} }
		
		public override string ToString()
		{
			return string.Format("Suscriptor={0}, MesesDeSuscripcion={1}, HorasVistas={2}", base.Nombre, mesesDeSuscripcion, horasVistas);
		}
		
		public override bool sosIgual(Comparable elem){
			if (elem is Visualizacion)
			{
				Visualizacion v = (Visualizacion)elem;
			    return mesesDeSuscripcion.CompareTo(v.getCantidad) == 0;
			}
			Suscriptor sus= (Suscriptor)elem;
			return mesesDeSuscripcion.CompareTo(sus.mesesDeSuscripcion)==0;
		}
		public override bool sosMenor(Comparable elem){
			if (elem is Visualizacion)
			{
				Visualizacion v= (Visualizacion)elem;
				return mesesDeSuscripcion.CompareTo(v.getCantidad)<0;
			}
			Suscriptor sus=(Suscriptor)elem;
			return mesesDeSuscripcion.CompareTo(sus.mesesDeSuscripcion)<0;
		}
		public override bool sosMayor (Comparable elem){
			if (elem is Visualizacion)
			{
				Visualizacion v=(Visualizacion)elem;
				return mesesDeSuscripcion.CompareTo(v.getCantidad)>0;
			}
			Suscriptor sus=(Suscriptor)elem;
			return mesesDeSuscripcion.CompareTo(sus.mesesDeSuscripcion)>0;
		}

	}
}
