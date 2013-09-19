using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.DataStructure;
using SQS.Controller;

namespace SQS.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((LoginType)Enum.Parse(typeof(LoginType), DropDownList_LoginType.SelectedValue) == LoginType.visitor)
                {
                    TextBox_UserName.Enabled = false;
                    TextBox_Password.Enabled = false;
                }
            }
        }

        protected void IBLogin_Click(object sender, ImageClickEventArgs e)
        {
            string exception = "";
            UserInfo userInfo = new UserInfo();
            string id = TextBox_UserName.Text; ;
            string passWord = TextBox_Password.Text; 
            LoginType loginType = (LoginType)Enum.Parse(typeof(LoginType), DropDownList_LoginType.SelectedValue);
            if ((loginType == LoginType.manager))
            {
                if (id == "" || passWord == "")
                {
                    ErrorMessage.Text = "用户名、密码不能为空！";
                    ErrorMessage.Visible = true;
                    return;
                }
            }
            
            if (LoginManagementCtrl.LoginIn(ref userInfo, id, passWord, loginType, ref exception))
            {
                Session["UserID"] = userInfo.Id;
                Session["UserName"] = userInfo.Name;
                Session["AccessLevel"] = userInfo.AccessLevel;
                Response.Redirect("Pages/HomePage.aspx");
            }
            else
            {
                ErrorMessage.Text = exception + "\n请输入正确的用户名密码并选择正确的身份！";
                ErrorMessage.Visible = true;
            }
        }

        protected void DropDownList_LoginType_SelectedChanged(object sender, EventArgs e)
        {
            if ((LoginType)Enum.Parse(typeof(LoginType), DropDownList_LoginType.SelectedValue) == LoginType.visitor)
            {
                TextBox_UserName.Text = "";
                TextBox_Password.Text = "";
                TextBox_UserName.Enabled = false;
                TextBox_Password.Enabled = false;
            }
            else
            {
                TextBox_UserName.Enabled = true;
                TextBox_Password.Enabled = true;
            }
        }
    }
}