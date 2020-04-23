using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWebApp.ServiceReference1;


namespace MyWebApp
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceClient obj = new ServiceClient();
            Response.Write("result = " + obj.Add(1, 2).ToString());
        }
    }
}