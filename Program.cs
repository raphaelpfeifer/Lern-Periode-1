using System;

namespace LA_Auftrag1_Eingabeaufforderung
{
    internal class Programm
    {
        private static void Main(string[] args)
        {
            bool weiterspielen = true;

            while (weiterspielen)
            {
                Console.WriteLine("Wie heissisch du?");
                string name = Console.ReadLine();

                Console.WriteLine("crazy name");
                Console.WriteLine("Wie alt bisch du?");

                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Hoi {name}, Du bisch jetzt grad {age} johr alt.");

                Console.WriteLine("Was isch dis lieblingsesse?");
                string essen = Console.ReadLine();

                Console.WriteLine($"Dis Lieblingsesse isch {essen}. Schrib eis esse, wo du denksch das es die meischte andere am liebste händ");

                string vermutung = Console.ReadLine();

                Console.WriteLine($"Du dennksch die meiste andere händ gern {vermutung}. Druck en beliebige Taste.");

                Console.ReadKey();

                Console.WriteLine("Uf platz 3 vo de beliebtischte esse isch Burger. Uf Platz 2 isch Pasta und uf Platz 1 isch Pizza");

                Console.ReadKey();

                
                Console.WriteLine(" Wotsch no einisch spiele? Gib 'ja' oder 'nein' ih:");
                string antwort = Console.ReadLine().ToLower();

                
                if (antwort != "ja")
                {
                    weiterspielen = false;
                }
            }

            Console.WriteLine("Tschüss und danke fürs Spiele!");
        }
    }
}
