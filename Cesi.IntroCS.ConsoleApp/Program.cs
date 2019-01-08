using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cesi.IntroCS.GotSDK;

namespace Cesi.IntroCS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bonjour, veuillez saisir votre nom s'il vous plait : ");
            //string userName = Console.ReadLine();

            //DateTime now = DateTime.Now;

            //ExempleBasicConcat(userName, now);
            ////ExempleStringFormat(userName, now);
            ////ExempleStringBuilder();

            //ExempleHttpClient().Wait();

            ////ExempleTaskRun().Wait();

            //// ExempleDelegate();

            //// ExempleFunc();
            ///
            ///
            

        


            Console.WriteLine("Pressez n'importe quelle touche pour quitter");
            Console.ReadKey();
        }

        #region StringFormat Exemple
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
        #endregion

        #region Delegate Exemple
        delegate double MathAction(double num);

        static double Double(double input)
        {
            return input * 2;
        }

        private static void ExempleDelegate()
        {
            //instantiate delegate
            MathAction ma = Double;

            // invoke
            double multByTwo = ma(4.5);
            Console.WriteLine("multByTwo: {0}", multByTwo);

            // instantiate delegate with anonymous method
            MathAction ma2 = delegate (double input)
            {
                return input * input;
            };

            double square = ma2(5);
            Console.WriteLine("square: {0}", square);

            // instantiate delegate with lambda expression
            MathAction ma3 = (s) => s * s * s;
            double cube = ma3(4.375);

            Console.WriteLine("cube: {0}", cube);
        }
        #endregion

        #region Action and Func

        private static void ExempleFunc()
        {
            Func<double, double> multByTwo = Double;
            Console.WriteLine("multByTwo: {0}", multByTwo(4.5));

            Func<double, double> square = (input) => input * input;
            Console.WriteLine("square: {0}", square);

            Func<double, double> cube = (s) => s * s * s;
            Console.WriteLine("cube: {0}", cube);
        }

        #endregion

        #region Async Exemple

        private static async Task ExempleHttpClient()
        {
            //HttpClient client = new HttpClient();

            //string data = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/583");

            //Console.WriteLine(data);

            GotClient gotClient = new GotClient();
            IList<Book> books = await gotClient.FindBook(b => b.NumberOfPages > 500);
            
        }

        private static async Task ExempleTaskRun()
        {
            try
            {
                ShowThreadInfo("Application");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Fin du traitement");
            }




            await Task.Run(() =>
            {
                ShowThreadInfo("Task");
            });

           
    


            // The example displays the following output:
            //       Application thread ID: 1
            //       Task thread ID: 3
        }

        private static void ShowThreadInfo(String s)
        {
            Console.WriteLine("{0} Thread ID: {1}", s, Thread.CurrentThread.ManagedThreadId);
        }

        #endregion
    }
}
