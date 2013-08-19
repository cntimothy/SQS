<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SQS.UI.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>科研成果查询统计系统欢迎您！</title>
    <link href="../Style/alogin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="Main">
        <ul>
            <li class="top"></li>
            <li class="top2"></li>
            <li class="topA"></li>
            <li class="topB"><span>
                <img src="../images/login/logo.gif" alt="" style="" />
            </span></li>
            <li class="topC"></li>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <li class="topD">
                        <ul class="login">
                            <li><span class="left">用户名：</span> <span style="left">&nbsp;</span> <span>
                                <asp:TextBox ID="UserName" runat="server" Style="margin-top: 0px" CssClass="txt"></asp:TextBox>
                            </span></li>
                            <li><span class="left">密 码：</span> <span style="left">&nbsp;</span> <span>
                                <asp:TextBox ID="Password" runat="server" Style="margin-top: 0px" CssClass="txt"
                                    TextMode="Password"></asp:TextBox>
                            </span></li>
                            <li><span class="left">登陆身份：</span> <span style="left">&nbsp;</span> <span>
                                <asp:DropDownList ID="LoginType" runat="server" CssClass="txt">
                                    <asp:ListItem Value="0">管理员</asp:ListItem>
                                    <asp:ListItem Value="1" Selected="True">考评者</asp:ListItem>
                                </asp:DropDownList>
                            </span></li>
                            <li><span>
                                <asp:Label ID="ErrorMessage" runat="server" Visible="False" ForeColor="Red"></asp:Label>
                            </span></li>
                        </ul>
                    </li>
                    <li class="topE"></li>
                    <li class="middle_A"></li>
                    <li class="middle_B"></li>
                    <li class="middle_C"><span class="btn">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="IBLogin" runat="server" ImageUrl="../images/login/btnlogin.gif"
                            OnClick="IBLogin_Click" />
                    </span></li>
                    <li class="middle_D"></li>
                    <li class="bottom_A"></li>
                    <li class="bottom_B"></li>
                </ContentTemplate>
            </asp:UpdatePanel>
        </ul>
    </div>
    </form>
</body>
</html>
