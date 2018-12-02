using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.ConsoleApp
{
    public class CombinedExercise1
    {
        /// <summary>
        /// La méthode suivante doit retourner true si chaque element dans la liste squares 
        /// est égale au carré de l'element correspondant dans la liste numbers.
        /// Essayé d'écrire la méthode entière en utilisant seulement des appels aux méthodes LINQ
        /// et sans écrire une seul boucle.
        /// </summary>
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            //return numbers
            //   // .???().???() ... .???()
            //   ;

            //var intersect = numbers.Select(n => n * n).Intersect(squares);
            //return intersect.Count() == squares.Count();

            return numbers.Select(n => n * n).SequenceEqual(squares);


        }
    }

    public class CombinedExercise2
    {
        /// <summary>
        /// Avec une suite de mots, éliminez ceux qui n'ont pas le caractère 'e' en eux,
        /// puis triez les mots restants par ordre alphabétique, et retourner la phare suivante en utilisant le dernier mot de la liste :
        ///     -> "The last word is <word>"
        /// S'il n'y a pas de mots avec le caractère 'e' dedans, alors on retourne null.
        /// Utilisez uniquement les instructions LINQ. Pas de boucles ni de si.
        /// </summary>
        public static string GetTheLastWord(IEnumerable<string> words)
        {
            //return words
            //    // .???().???() ... .???()
            //    ;

            return words.Where(w => w.Contains('e'))
                            .OrderBy(w => w)
                            .Select(w => $"The last word is {w}")
                            .LastOrDefault();

        }
    }
}
