using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomValidatorDemo
{
    public partial class CustomValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            Session["Captcha"] = lblMABM.Text = r.Next(10000, 99999).ToString();
        }

        protected void valCaptcha_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value == Session["Captcha"].ToString());
        }
    }
}