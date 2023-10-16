using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Extra_Football_club.View
{
	internal class View
	{
		/// <summary>
		/// This method outputs a custom message, based on the string parameter.
		/// </summary>
		/// <param name="message"></param>
		internal void Message(string message)
		{
            Console.WriteLine(message);
        }

		/// <summary>
		/// This method changes between white and dark gray colors, based on the parameter value and modulus.
		/// </summary>
		/// <param name="value"></param>
		internal void Color (byte value)
		{
			if (value % 2 == 1)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
			}
		}

		/// <summary>
		/// This method clears the console.
		/// </summary>
		internal void Clear()
		{
			Console.Clear();
		}

		/// <summary>
		/// This method returns a Console.ReadLine().
		/// </summary>
		/// <returns></returns>
		internal string ReadLine()
		{
			return Console.ReadLine();
		}

		/// <summary>
		/// This method resets the console color to white.
		/// </summary>
		internal void ResetColor()
		{
			Console.ResetColor();
		}
	}
}
