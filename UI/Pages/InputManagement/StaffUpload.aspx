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
                            <x:Form ID="Form2" runat="server" BodyPadding="5px" Title="Form" ShowHeader="false" ShowBorder="false">
                                <Rows>
                                    <x:FormRow ID="FormRow1" runat="server">
                                        <Items>
                                            <x:DropDownList ID="DropDownList1" runat="server" Label="请选择部系">
                                                <x:ListItem Selected="true" EnableSelect="true" Text="所有部系" Value="0" />
                                            </x:DropDownList>
                                            <x:DropDownList ID="DropDownList2" runat="server" Label="请选择处室">
                                                <x:ListItem Selected="true" EnableSelect="true" Text="所有处室" Value="0" />
                                            </x:DropDownList>
                                        </Items>
                                    </x:FormRow>
                                </Rows>
                            </x:Form>
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
