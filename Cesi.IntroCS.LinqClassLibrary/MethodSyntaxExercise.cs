using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary
{
    public static class MethodSyntaxExercise
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
            //return inValues
            //     // LINQ method calls here
            //     ;

            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.First(val => val > 2.3);



            return inValues
                .Where(v => v.Contains(pattern))
                .OrderBy(v => v);
        }
    }
}
