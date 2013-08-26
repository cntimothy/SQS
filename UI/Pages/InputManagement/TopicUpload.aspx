<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TopicUpload.aspx.cs" Inherits="SQS.UI.Pages.InputManagement.TopicUpload" %>

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
                            <x:Grid ID="Grid1" runat="server" Title="著作统计表" EnableRowNumber="true"
                                AllowPaging="true" PageSize="20" Height="500px" AutoScroll="true"  >
                                <Columns>
                                    <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="部系单位" />
                                    <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="处室单位" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                                    <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="课题名称" />
                                    <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="课题级别" />
                                    <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="立项时间（年月）" />
                                    <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="结题时间（年月）" />
                                    <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="奖励级别" />
                                    <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="奖励等级" />
                                    <x:BoundField Width="50px" DataField="Name" DataFormatString="{0}" HeaderText="完成形式" />
                                    <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="字数" />
                                    <x:BoundField Width="50px" DataField="Name" DataFormatString="{0}" HeaderText="参与人数" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="参与人1" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="参与人2" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="参与人3" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="参与人4" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="5人以上（含）" />
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
