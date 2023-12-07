using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class countingViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["data"] = 0;

                Label1.Text = ViewState["data"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ViewState["data"] = Convert.ToInt32(ViewState["data"]) + 1;
            Label1.Text = ViewState["data"].ToString();


        }
    }
}