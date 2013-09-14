<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe_ModifyPaperInformation.aspx.cs" Inherits="SQS.UI.Pages.InputManagement.iframe_ModifyPaperInformation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel" Layout="VBox" BoxConfigAlign="Stretch">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <x:Button ID="Button_Update" runat="server" Text="修改" OnClick="Button_Update_Click" ConfirmText="确定修改？">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_Reset" runat="server" Text="重置" OnClick="Button_Reset_Click" ConfirmText="确定重置？">
                    </x:Button>
                    <x:ToolbarFill ID="ToolbarFill1" runat="server">
                    </x:ToolbarFill>
                    <x:Button ID="Button_Close" runat="server" Text="关闭">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel" BoxFlex="1" Layout="Fit">
                <Items>
                    <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="5px" Title="SimpleForm"
                        AutoScroll="true" ShowBorder="false" ShowHeader="false" LabelWidth="110px" LabelAlign="Right">
                        <Items>
                            <x:DropDownList ID="DropDownList_Depart" runat="server" Label="部系" Width="150px"
                                AutoPostBack="true" OnSelectedIndexChanged="DropDownList_Depart_SelectedChanged">
                            </x:DropDownList>
                            <x:DropDownList ID="DropDownList_Office" runat="server" Label="处室" Width="150px"
                                Enabled="false">
                            </x:DropDownList>
                            <x:TextBox ID="TextBox_Name" runat="server" Label="姓名" Text="" Width="150px">
                            </x:TextBox>
                            <x:TextBox ID="TextBox_PaperName" runat="server" Label="论文名称" Text="" Width="200px">
                            </x:TextBox>
                            <x:TextBox ID="TextBox_JournalName" runat="server" Label="发表刊物、会议或文集名称" Text="" Width="200px">
                            </x:TextBox>
                            <x:DatePicker ID="DatePicker_PublishDate" runat="server" Label="发表时间（年月）" Width="150px" DateFormatString="yyyy-MM">
                            </x:DatePicker>
                            <x:DropDownList ID="DropDownList_PublishGrade" runat="server" Label="发表级别" Width="200px">
                            </x:DropDownList>
                            <x:DropDownList ID="DropDownList_RewardGrade" runat="server" Label="奖励级别" Width="200px">
                            </x:DropDownList>
                            <x:DropDownList ID="DropDownList_RewardClass" runat="server" Label="奖励等级" Width="200px">
                            </x:DropDownList>
                            <x:NumberBox ID="NumberBox_WordCount" runat="server" Label="字数" Width="100px">
                            </x:NumberBox>
                            <x:NumberBox ID="NumberBox_AutherCount" runat="server" Label="编写人数" Width="100px">
                            </x:NumberBox>
                            <x:DropDownList ID="DropDownList_AutherOrder" runat="server" Label="第几作者" Width="200px">
                                <x:ListItem EnableSelect="true" Text="第一作者" Value="1" />
                                <x:ListItem EnableSelect="true" Text="第二作者" Value="2" />
                                <x:ListItem EnableSelect="true" Text="第三作者" Value="3" />
                            </x:DropDownList>
                        </Items>
                    </x:SimpleForm>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
