using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_the_basics_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asher H.P.
            string firstName = "Asher";
            string favMovie = "THE MATRIX";
            string favQuote = "'No offense, but I'm not taking advice from a guy who eats bread.' - Brian Griffin";
            Console.WriteLine($"Hello! My name's {firstName.ToLower()} & my favourite movie is {favMovie.ToLower()}.");
            Console.Write(favMovie.Contains("THE"));
            favMovie = favMovie.Replace("E", "3");
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("I", "1");
            favMovie = favMovie.Replace("X", "%");
            favMovie = favMovie.Replace("T", "7");
            Console.WriteLine($" I really like {favMovie}");
            favQuote = favQuote.Replace("a", "");
            favQuote = favQuote.Replace("e", "");
            favQuote = favQuote.Replace("i", "");
            favQuote = favQuote.Replace("I", "");
            favQuote = favQuote.Replace("o", "");
            favQuote = favQuote.Replace("u", "");
            favQuote = favQuote.Replace("y", "");
            Console.WriteLine(favQuote);
            Console.WriteLine("Look at these birds!");
            Console.Write("              __            ");
            Console.WriteLine("  ,~");
            Console.Write("             /'{>           ");
            Console.WriteLine(" ('v)__");
            Console.Write("         ____) (____        ");
            Console.WriteLine("(/ (``/");
            Console.Write("        /'--;   ;--'\\       ");
            Console.WriteLine(" \\__>'");
            Console.Write("       //////\\_/\\\\\\\\\\\\      ");
            Console.WriteLine("  ^^");
            Console.WriteLine("             m m");

            Console.WriteLine(Console.ReadLine());
        }
    }
}
