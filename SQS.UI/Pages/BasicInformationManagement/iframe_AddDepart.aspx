<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe_AddDepart.aspx.cs" Inherits="SQS.UI.Pages.BasicInformationManagement.iframe_AddDepart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <x:Button ID="Button_AddNew" runat="server" Text="新增" OnClick="Button_AddNew_Click" ConfirmText="确定新增？">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_Cancel" runat="server" Text="取消">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="5px" Title="SimpleForm" ShowBorder="false" ShowHeader="false">
                <Items>
                    <x:TextBox ID="TextBox_NewDepart" runat="server" Label="请输入新部系名称" Text="">
                    </x:TextBox>
                </Items>
            </x:SimpleForm>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
