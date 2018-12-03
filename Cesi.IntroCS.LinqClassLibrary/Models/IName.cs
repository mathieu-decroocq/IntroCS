using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqClassLibrary.Models
{
    public interface IName
    {
        string First { get; }
        string Middle { get; }
        string Last { get; }
    }
}
