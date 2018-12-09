using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary
{
    public static class QuerySyntaxExercise
    {
        /// <summary>
        /// Retourner seulement les strings qui contiennent le pattern passé en paramètre
        /// et trié la liste par ordre alphabétique
        /// </summary>
        /// <param name="inValues"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            //return from value in inValues
            //           // LINQ instructions here
            //       select value;
        }
    }
}
