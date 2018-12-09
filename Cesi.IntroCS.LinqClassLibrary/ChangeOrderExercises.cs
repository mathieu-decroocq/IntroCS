using Cesi.IntroCS.LinqClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary
{
    public static class ChangeOrderExercises
    {

        /// <summary>
        /// Retourne la liste des noms, trié sur la propriété Last, dans l'order décroissant
        /// </summary>
        public static IEnumerable<IName> SortNamesByLast(IEnumerable<IName> names)
        {
            // Uncomment:
            // return names.???();
        }

        // Return the provided list of names, ordered by Last, then
        // First, then Middle
        public static IEnumerable<IName> SortNamesByLastAndFirstAndMiddle(IEnumerable<IName> names)
        {
            // Uncomment:
            // return names.???();
        }
    }

}
