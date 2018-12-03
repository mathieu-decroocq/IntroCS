using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary
{
    public static class SingleCalculatedValueExercises
    {

        /// <summary>
        /// Retourne le nombre de strings dans la séquence fournis commençant par le paramêtre "startString"
        /// </summary>
        public static int NumberThatStartWith(IEnumerable<string> words, string startString)
        {
            // Uncomment:
            // return words.???();
     
            return words.Count(w => w.StartsWith(startString));
        }

        /// <summary>
        /// Renvoie la longueur du mot le plus court
        /// </summary>
        public static object LengthOfShortestWord(string[] words)
        {
            // Uncomment:
            // return words.???();

            return words.Min(w => w.Length);
        }
    }
}
