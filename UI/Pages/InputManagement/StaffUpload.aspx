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
                            <x:Button ID="Button_Submit" runat="server" Text="开始上传" OnClick="Button_Submit_Click"
                                Enabled="false">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator4" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button1_Export" runat="server" Text="导出" OnClick="Button_Export_Click"
                                EnableAjax="false" DisableControlBeforePostBack="false">
                            </x:Button>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Button ID="Button_DownloadTemplate" runat="server" Text="下载模板" OnClick="Button_DownloadTemplate_Click"
                                EnableAjax="false">
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                    <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                        Title="">
                        <Items>
                            <x:Grid ID="Grid1" runat="server" Title="单位区分表" EnableRowNumber="true" AllowPaging="false"
                                Height="500px" AutoScroll="true">
                                <Columns>
                                    <x:BoundField Width="200px" DataField="Depart" DataFormatString="{0}" HeaderText="部系" />
                                    <x:BoundField Width="200px" DataField="Office" DataFormatString="{0}" HeaderText="处室" />
                                    <x:BoundField Width="150px" DataField="OfficeStaffCount" DataFormatString="{0}" HeaderText="处室人数" />
                                    <x:BoundField Width="150px" DataField="DepartStaffCount" DataFormatString="{0}" HeaderText="部系总人数" />
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
