using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASM_ValidationControls
{
    public partial class ASPNETValidaiton1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            valNgaySinh.ValueToCompare = DateTime.Now.AddYears(-16).ToString("MM/dd/yyyy");
        }
    }
}