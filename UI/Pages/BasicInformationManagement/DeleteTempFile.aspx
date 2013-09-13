<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteTempFile.aspx.cs"
    Inherits="SQS.UI.Pages.BasicInformationManagement.DeleteTempFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel" AutoScroll="true">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <x:Button ID="Button_Delete" runat="server" Text="删除临时文件" OnClick="Button_Delete_Click"
                        ConfirmText="确定删除临时文件？">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel">
                <Items>
                    <x:Label ID="Label1" runat="server" Label="Label" Text="导出Excel的时候将在服务器端生成临时文件，请经常删除这些文件以节省硬盘空间！">
                    </x:Label>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
