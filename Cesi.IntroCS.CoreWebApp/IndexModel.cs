using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cesi.IntroCS.CoreWebApp
{
    public class IndexModel : PageModel
    {
        IDependency dependency;
        public IndexModel(IDependency dependency)
        {
            this.dependency = dependency;
        }

        public async Task OnGetAsync()
        {
            await dependency.WriteMessage(
                "IndexModel.OnGetAsync created this message.");
        }
    }
}
