using System;
using System.Collections;
//using System.Text.RegularExpression;


class Run {
	//public bool spellCheck = false;
	public static void Main(string[] args) {
		bool rd = false;
		string qs;
		start();
		void start() {
			switch (rd)
			{
				case false:
					Console.WriteLine("\nThis project is for calculating the circumference of a circle\n" +
					"to continue, please enter the radius of your circle...");
					rd = true;
					break;
				case true:
					Console.WriteLine("\nto continue, please enter the radius of your circle...");
					break;

			}

			qs = Console.ReadLine();
			bool checke = check(qs);
			if (checke) {
				Console.WriteLine("Your radius was: " + qs + "\nThe circumference is:");
				float r = float.Parse(qs);
				Console.Write((r*r) * Math.PI);
			}
			else {
				Console.WriteLine("your text could not be converted to float\n" +
					"Press any [Key] to reset");
				Console.ReadKey();
				start();
			}
		}
		bool check(string str) {
			foreach (char c in str) {
				if (c < '0' || c > '9' || c == '.') {
					return false;
				}
			}
			return true;
		}
		void error()
		{

		}
	}
}