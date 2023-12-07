using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class dropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string SelectedCorlor = DropDownList1.SelectedValue;
            HttpCookie ColorCookie = new HttpCookie("ColorCookie");
            ColorCookie.Value = SelectedCorlor;
            Response.Cookies.Add(ColorCookie);
            Response.Redirect("ColorOutputPage.aspx");
        }
    }
}