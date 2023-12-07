using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1027
{
    public partial class controller_practice : System.Web.UI.Page
    {
        DateTime today = DateTime.Today;

        protected void Page_Load(object sender, EventArgs e)
        {




        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello, " + TextBox1.Text + "，請完成以下表單";
        }




        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label2.Text = today.ToString("D");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label3.Text = today.ToString("dddd");
        }




        protected void ddlImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 在 DropDownList 的選擇變更事件處理程序中不執行任何操作

            string selectedImage = "";
            if (DropDownList1.SelectedValue == "春")
            {
                Image1.ImageUrl = "https://plus.unsplash.com/premium_photo-1674917070243-905c3bbf1576?auto=format&fit=crop&q=80&w=1226&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            }
            else if (DropDownList1.SelectedValue == "夏")
            {
                Image1.ImageUrl = "https://images.unsplash.com/photo-1557434440-d4d48e6578b5?auto=format&fit=crop&q=80&w=1035&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            }
            else if (DropDownList1.SelectedValue == "秋")
            {
                Image1.ImageUrl = "https://images.unsplash.com/photo-1444492417251-9c84a5fa18e0?auto=format&fit=crop&q=80&w=1035&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            }
            else if (DropDownList1.SelectedValue == "冬")
            {
                Image1.ImageUrl = "https://images.unsplash.com/photo-1510798831971-661eb04b3739?auto=format&fit=crop&q=80&w=987&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            }



        }


        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            string sch = "";
            foreach (ListItem item in cblOptions.Items)
            {
                if (item.Selected)
                {
                    sch += item + " ";
                }
            }

            string meal_1 = "";
            string meal_2 = "";
            if (rbOption1.Checked)
            {
                meal_1 = rbOption1.Text;
            }
            else if (rbOption2.Checked)
            {
                meal_1 = rbOption2.Text;
            }

            if (rbOption3.Checked)
            {
                meal_2 = rbOption3.Text;
            }
            else if (rbOption4.Checked)
            {
                meal_2 = rbOption4.Text;
            }
            else if (rbOption5.Checked)
            {
                meal_2 = rbOption5.Text;
            }


            //bool isChecked = CheckBox1.Checked;
            string message = "";
            if (CheckBox1.Checked)
            {
                message = "會";
            }
            else
            {
                message = "不會";
            }


            Literal1.Text = $"<br/>---- 將提供您一個 ----<h3>有 {sch}行程的</h3><h3>{DropDownList1.SelectedValue}季 5天 海外旅行團</h3>團員年齡層: {RadioButtonList1.SelectedValue}<br />提供機上餐點: {meal_2} {meal_1}食<br/> " +
                $"您<b>{message}</b>收到廣告訊息";


        }

    }
}