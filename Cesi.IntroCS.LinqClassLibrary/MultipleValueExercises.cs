using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary
{
    public static class MultipleValueExercises
    {
        /// <summary>
        /// Retourne les 3eme, 4eme et 5eme éléments
        /// </summary>
        public static IEnumerable<string> GetThirdFourthFifthItems(
          IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
        }


        /// <summary>
        /// Retourne tous les mots de la séquence entre "start" (inclus) et "end" (non inclus)
        /// </summary>
        /// <example>
        /// Pour { "One", "start", "more", "end", "thing" }
        /// Doit retourner { "start", "more" }
        /// </example>
        public static IEnumerable<string> GetStartThroughEnd(IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
        }



        /// <summary>
        /// Retourne tous les mots comportant moins de quatre lettres sans avoir de double.
        /// </summary>
        public static IEnumerable<string> GetDistinctShortWords(
            IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
        }
    }
}
