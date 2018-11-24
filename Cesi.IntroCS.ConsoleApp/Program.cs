using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez saisir votre nom s'il vous plait : ");
            string userName = Console.ReadLine();

            DateTime now = DateTime.Now;

            ExempleBasicConcat(userName, now);
            //ExempleStringFormat(userName, now);
            //ExempleStringBuilder();

            Console.WriteLine("Pressez n'importe quelle touche pour quitter");
            Console.ReadKey();
        }

        private static void ExempleBasicConcat(string userName, DateTime now)
        {
            string output = "Bonjour " + userName + ". Nous sommes en " + now.Year + " et il est " + now.ToShortTimeString() + ".";

            Console.WriteLine(output);
        }

        private static void ExempleStringBuilder()
        {
            StringBuilder builder = new StringBuilder();
            // Append to StringBuilder.
            for (int i = 0; i < 10; i++)
            {
                builder.Append(i).Append(" ");
            }
            Console.WriteLine(builder);
            // show : 0 1 2 3 4 5 6 7 8 9
        }

        private static void ExempleStringFormat(string userName, DateTime now)
        {
            string outputV2 = string.Format("Bonjour {0}. Nous sommes en {1} et il est {2}.", userName, now.Year, now.ToShortTimeString());
            string outputV3 = $"Bonjour {userName}. Nous sommes en {now.Year} et il est {now.ToShortTimeString()}.";

            Console.WriteLine(outputV2);
            Console.WriteLine(outputV3);
        }





        // Affiche le contenu de la variable dans la fenetre Sortie
        //Debug.WriteLine(outputV1);
        //    throw new Exception("Mon code a planté !");
    }
}
