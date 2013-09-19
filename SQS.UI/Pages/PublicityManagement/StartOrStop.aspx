<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartOrStop.aspx.cs" Inherits="SQS.UI.Pages.PublicityManagement.StartOrStop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        AutoScroll="true" Title="Panel">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <x:Button ID="Button_Start" runat="server" Text="开始公示" ConfirmText="确定开始公式？开始公示后，相关人员将能够进行查询"
                        OnClick="Button_Start_Click">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_Stop" runat="server" Text="结束公示" ConfirmText="确定结束公式？结束公示后，相关人员将不能进行查询" OnClick="Button_Stop_Click">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="5px" Title="SimpleForm"
                ShowBorder="false" ShowHeader="false">
                <Items>
                    <x:Label ID="Label_Status" runat="server" Label="当前公示状态" Text="">
                    </x:Label>
                </Items>
            </x:SimpleForm>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
