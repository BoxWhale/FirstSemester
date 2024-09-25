//Notes to add to this project3:
//Add Functions [Added]
//Add Types [Added]
//Add Loops [Added]
//Add structs [Not Added]
//Add Exceptions [Added]

using System;
using System.Collections;
using System.Runtime;
using System.Linq;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.AccessControl;
//using System.Text.RegularExpression;

class Run
{
    //public bool spellCheck = false;
    public static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("us-US");
        float[] r = new float[0];
        //Console.WriteLine(r[r.Length-1] + "" + r.Length);
        //Array.Resize(ref r, r.Length+1);
        //Console.WriteLine(r[r.Length-1] + "" + r.Length);
        bool rd = false;
        string qs;

        start();
        void start()
        {
            switch (rd)
            {
                case false:
                    Console.WriteLine("\nThis project is for calculating the circumference of multiple circles,\n" +
                    "and then outputs the sum of the circumferences\n" +
                    "to continue, please enter the radius of your circle...");
                    rd = true;
                    ask();
                    break;
                case true:
                    Console.WriteLine("\nto continue, please enter the radius of your circle...");
                    ask();
                    break;

            }
        }
        void ask()
        {
            qs = Console.ReadLine();
            bool checke = check(qs);
            try
            {
                //new Dic
                Array.Resize(ref r, r.Length + 1);
                r[r.Length - 1] = float.Parse(qs);
                Console.Write("\nYour circle got the circumference of: " + 2 * r[r.Length - 1] * Math.PI);
                if (r.Length > 1)
                {
                    float sum = 0;
                    Console.Write("\nAnd gives you a circumference sum of: ");
                    for (int i = 1; i <= r.Length; i++)
                    {
                        sum += 2 * r[i - 1] * MathF.PI;
                    }
                    Console.Write(sum);

                }
                more();
            }
            catch (Exception ex)
            {
                Console.WriteLine("CodeError:\n" + ex.ToString() + "\n" +
                    "your text could not be converted to type float\nPress any [Key] to reset");

                Console.ReadKey();
                start();
            }

        }
        bool check(string str)
        {
            float f = 0;
            bool b = float.TryParse(str, out f);
            //Console.WriteLine(f);
            return b;
        }
        void more()
        {
            Console.WriteLine("\nWould you like to add another radius? Y/n");
            string read = Console.ReadLine();
            if (read.ToUpper() == "Y")
            {
                start();
            }

            //Environment.Exit(0);
        }
    }
}
