﻿using System.Threading.Channels;

namespace LA_Auftrag1_Eingabeaufforderung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wie heissisch du?");

            string name = Console.ReadLine();

            Console.WriteLine("crazy name");
            Console.WriteLine("Wie alt bisch du?");

            int alter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hoi {name}, Du bisch jetzt grad {alter} johr alt.");

            Console.WriteLine("Was isch dis lieblingsesse");
            string essen = Console.ReadLine();

            Console.WriteLine($"Dis Lieblingsesse isch {essen}. Schrib eis esse, wo du denksch das es die meischte andere am liebste händ");

            string vermutung = Console.ReadLine();


            Console.WriteLine($"Du dennksch die meiste andere händ gern {vermutung}. Druck en beliebige Taste und den Enter.");

            string Lieblingsesse = Console.ReadLine();

            Console.WriteLine($"Platz 3 isch Burger, Platz 2 isch Pasta und uf Platz Nummer 1 isch Pizza.");



            Console.ReadKey();


        }
    }
}
