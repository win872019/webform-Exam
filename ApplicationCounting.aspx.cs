using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class ApplicationCounting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["data"] != null)
                {
                    Label1.Text = Application["data"].ToString();
                }
                else
                {
                    Application["data"] = 0;
                    Label1.Text = Application["data"].ToString();
                }

            }
            else
            {
                if (Application["data"] != null)
                {
                    Label1.Text = Application["data"].ToString();
                }
                else
                {
                    Application["data"] = 0;
                    Label1.Text = Application["data"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Application["data"] = Convert.ToInt32(Application["data"]) + 1;
            Label1.Text = Application["data"].ToString();
            Response.Redirect("ApplicationCounting.aspx");


        }
    }
}