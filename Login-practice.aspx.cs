using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class Login_practice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    string username = Session["Username"].ToString();
                    if (username == "user")
                    {
                        StatusLabel.Text = "登入狀態: 已登入";
                    }
                }

                else
                {
                    StatusLabel.Text = "登入狀態: 未登入，請輸入帳號密碼";
                }
            }

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (username == "user" && password == "password")
            {
                Session["Username"] = username;

                Response.Redirect("welcome-practice.aspx");

            }
            else
            {
                StatusLabel.Text = "登入狀態: 登入失敗 ";
            }
        }
    }
}