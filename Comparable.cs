/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 23/8/2026
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo1_Complejidad
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface Comparable
	{
		bool sosIgual(Comparable elem);
		
		bool sosMenor(Comparable elem);
		
		bool sosMayor(Comparable elem);
	}
}
