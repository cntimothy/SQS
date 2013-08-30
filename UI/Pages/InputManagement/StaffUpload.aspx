<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffUpload.aspx.cs" Inherits="SQS.UI.Pages.InputManagement.StaffUpload" %>

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
        Title="Panel" Layout="Fit">
        <Items>
            <x:Panel ID="Panel3" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
                Title="Panel" AutoScroll="true">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server" CssClass="mytoolbar">
                        <Items>
                            <x:FileUpload ID="FileUpload_ExcelFile" runat="server" Label="Label" ButtonOnly="true"
                                ButtonText="选择上传文件" AutoPostBack="true" OnFileSelected="FileUpload_ExcelFile_FileSelected">
                            </x:FileUpload>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Label ID="Label1" runat="server" Label="Label" Text="您选择的文件是:">
                            </x:Label>
                            <x:Label ID="Label_FileName" runat="server" Label="Label" Text="">
                            </x:Label>
                            <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Submit" runat="server" Text="开始上传" OnClick="Button_Submit_Click" Enabled="false">
                            </x:Button>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Button ID="Button_DownloadTemplate" runat="server" Text="下载模板" OnClick="Button_DownloadTemplate_Click" EnableAjax="false">
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                    <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                        Title="Panel">
                        <Items>
                            <x:Panel ID="Panel4" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                                Title="搜索条件">
                                <Items>
                                    <x:Panel ID="Panel7" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                                        Title="Panel" Layout="HBox" BoxConfigChildMargin="0 5 0 0">
                                        <Items>
                                            <x:RadioButton ID="RadioButton_SearchByName" GroupName="SearchType" runat="server"
                                                Label="" Text="按姓名查找" OnCheckedChanged="SearchType_Changed" AutoPostBack="true"
                                                Checked="true">
                                            </x:RadioButton>
                                            <x:TextBox ID="TextBox_Name" runat="server" Label="" Text="" EmptyText="请输入姓名">
                                            </x:TextBox>
                                        </Items>
                                    </x:Panel>
                                    <x:Panel ID="Panel6" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                                        Title="Panel" Layout="HBox" BoxConfigChildMargin="0 5 0 0">
                                        <Items>
                                            <x:RadioButton ID="RadioButton_SearchByDepartAndOffice" GroupName="SearchType" runat="server"
                                                Label="" Text="按部系处室查找" AutoPostBack="true">
                                            </x:RadioButton>
                                            <x:DropDownList ID="DropDownList_Depart" runat="server" Label="" Enabled="false">
                                                <x:ListItem EnableSelect="false" Selected="true" Text="请选择部系" Value="0" />
                                            </x:DropDownList>
                                            <x:DropDownList ID="DropDownList_Office" runat="server" Label="" Enabled="false">
                                                <x:ListItem EnableSelect="false" Selected="true" Text="请选择处室" Value="0" />
                                            </x:DropDownList>
                                        </Items>
                                    </x:Panel>
                                    <x:Panel ID="Panel5" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false" 
                                        Title="Panel" Layout="HBox" BoxConfigChildMargin="0 5 0 0">
                                        <Items>
                                            <x:Label ID="Label2" runat="server" Label="Label" Text="选择起止年份">
                                            </x:Label>
                                            <x:DropDownList ID="DropDownList_StartYear" runat="server" Label="选择开始年份" Width="100px">
                                            </x:DropDownList>
                                            <x:Label ID="Label3" runat="server" Label="Label" Text=" 到 ">
                                            </x:Label>
                                            <x:DropDownList ID="DropDownList_StopYear" runat="server" Label="选择结束年份" Width="100px">
                                            </x:DropDownList>
                                            <x:Button ID="Button_Search" runat="server" Text="搜索">
                                            </x:Button>
                                        </Items>
                                    </x:Panel>
                                </Items>
                            </x:Panel>
                            <x:Grid ID="Grid1" runat="server" Title="单位区分表" EnableRowNumber="true" AllowPaging="true"
                                PageSize="20" Height="500px" AutoScroll="true">
                                <Columns>
                                    <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="部门" />
                                    <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="处室" />
                                    <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="处室编制人数" />
                                    <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="处室参研人数" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
