<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaperUpload.aspx.cs" Inherits="SQS.UI.Pages.InputManagement.PaperUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel" AutoScroll="true">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server" CssClass="mytoolbar">
                <Items>
                    <x:FileUpload ID="FileUpload1" runat="server" Label="Label" ButtonOnly="true" ButtonText="选择上传文件">
                    </x:FileUpload>
                    <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                    </x:ToolbarSeparator>
                    <x:Label ID="Label1" runat="server" Label="Label" Text="您选择的文件是：">
                    </x:Label>
                    <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button1" runat="server" Text="开始上传">
                    </x:Button>
                    <x:ToolbarFill ID="ToolbarFill1" runat="server">
                    </x:ToolbarFill>
                    <x:Button ID="Button2" runat="server" Text="下载模板">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel">
                <Items>
                    <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="0px" Title="SimpleForm"
                        ShowBorder="false" ShowHeader="false" CssStyle="width:50%">
                        <Items>
                            <x:DropDownList ID="DropDownList_Depart" runat="server" Label="请选择部门">
                                <x:ListItem Selected="true" EnableSelect="true" Text="所有部门" Value="0" />
                            </x:DropDownList>
                        </Items>
                    </x:SimpleForm>
                    <x:Grid ID="Grid1" runat="server" Title="学术论文统计表">
                        <Columns>
                        </Columns>
                    </x:Grid>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
