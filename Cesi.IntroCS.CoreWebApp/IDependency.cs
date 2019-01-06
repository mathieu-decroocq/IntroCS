using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cesi.IntroCS.CoreWebApp
{
    public interface IDependency
    {
        Task WriteMessage(string msg);
    }
}
