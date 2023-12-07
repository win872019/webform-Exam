using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class ColorOutputPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            else
            {

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie SelectedColor = Request.Cookies["ColorCookie"];
            if (SelectedColor != null)
            {
                string color = SelectedColor.Value;
                Label1.Text = "You Chose the " + color + " color.";
                Label1.ForeColor = System.Drawing.Color.FromName(color);

            }
        }
    }
}