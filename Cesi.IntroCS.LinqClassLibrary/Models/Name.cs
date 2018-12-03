using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary.Models
{
    public class Name : IName
    {
        public string First { get; }

        public string Middle { get; }

        public string Last { get; }

        public Name(string name)
        {
            var names = name.Split(' ');
            First = names[0];
            Middle = names[1];
            Last = names[2];
        }

        public override string ToString()
        {
            return $"{First} {Middle} {Last}";
        }
    }
}
