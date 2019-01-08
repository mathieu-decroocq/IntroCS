using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cesi.IntroCS.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myBtn.Text = "test";
        }

        protected void myBtn_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}