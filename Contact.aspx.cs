using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Contact : Page
    {
        string str = "start";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                str = "inside postback newone again new fifth sixth seventh eighth";
            }
        }
    }
}