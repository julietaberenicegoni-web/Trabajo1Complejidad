/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 23/8/2026
 * Time: 19:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface Coleccionable
	{
		int cuantos ();
		Comparable minimo ();
		Comparable maximo ();
		void agregar (Comparable elem);
		bool contiene (Comparable elem);
	}
}
