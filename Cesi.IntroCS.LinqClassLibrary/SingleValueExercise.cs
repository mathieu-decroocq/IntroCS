using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary
{
    public static class SingleValueExercise
    {
        
        /// <summary>
        /// A partir d'une séquence de mots, renvoyer le 1er mot avec une seul lettre
        /// Il y en aura toujours au moins un.
        /// </summary>
        public static string GetFirstSingleLetterWord(IEnumerable<string> words)
        {
            // return words.???();
            return words.First(w => w.Length == 1);
        }

        /// <summary>
        /// Retourner le dernier mot contenant la sous chaine "her".
        /// Il y en aura toujours au moins un.
        /// </summary>
        public static string GetLastWordWithHerInIt(IEnumerable<string> words)
        {
            // return words.???();
            return words.Last(w => w.Contains("her"));
        }

        /// <summary>
        /// Renvoie le cinquième mot de la séquence, s'il en existe un.
        /// S'il y a moins de 5 mots, retournez null.
        /// </summary>
        public static string GetFifthWordIfItExists(IEnumerable<string> words)
        {
            // return words.???();
            return words.ElementAtOrDefault(4);
        }

        /// <summary>
        /// Renvoie le dernier mot de la séquence.
        /// S'il n'y a pas de mots dans la séquence, retourne null.
        /// </summary>
        public static string GetLastWordIfAny(IEnumerable<string> words)
        {
            // return words.???();
            return words.LastOrDefault();
        }
    }
}
