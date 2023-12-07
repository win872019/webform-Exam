using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    string username = Session["Username"].ToString();
                    StatusLabel.Text = "Hello, " + username + "! 您已登入";
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }

        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session["Username"] = null;
            StatusLabel.Text = "登入狀態: 已登出";
            Response.Redirect("Login.aspx");

        }
    }
}