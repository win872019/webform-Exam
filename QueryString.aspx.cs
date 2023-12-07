using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["textToPass"] != null)
                {
                    string passedText = Request.QueryString["textToPass"];

                    lblReceivedText.Text = passedText;
                }
                else
                {
                    
                    string passedText = Request.QueryString["textToPass"];
    
                    lblReceivedText.Text = passedText;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = TextBox1.Text;
            //Request.QueryString["textToPass"] = text; //
            Response.Redirect("QueryString.aspx" + "?textToPass=" + text); // 把參數加到URL裡
        }
    }
}