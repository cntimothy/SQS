﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TopicUpload.aspx.cs" Inherits="SQS.UI.Pages.InputManagement.TopicUpload" %>

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
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Button ID="Button_DownloadTemplate" runat="server" Text="下载模板" OnClick="Button_DownloadTemplate_Click"
                                EnableAjax="false">
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
                            <x:Grid ID="Grid1" runat="server" Title="著作统计表" EnableRowNumber="true" AllowPaging="true"
                                PageSize="20" Height="500px" AutoScroll="true" DataKeyNames="ID">
                                <Columns>
                                    <x:BoundField Width="150px" DataField="ID" DataFormatString="{0}" HeaderText="ID"
                                        Hidden="true" />
                                    <x:BoundField Width="150px" DataField="Depart" DataFormatString="{0}" HeaderText="部系单位" />
                                    <x:BoundField Width="150px" DataField="Office" DataFormatString="{0}" HeaderText="处室单位" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                                    <x:BoundField Width="200px" DataField="TopicName" DataFormatString="{0}" HeaderText="课题名称" />
                                    <x:BoundField Width="200px" DataField="TopicGrade" DataFormatString="{0}" HeaderText="课题级别" />
                                    <x:BoundField Width="150px" DataField="StartTIme" DataFormatString="{0}" HeaderText="立项时间（年月）" />
                                    <x:BoundField Width="150px" DataField="StopTime" DataFormatString="{0}" HeaderText="结题时间（年月）" />
                                    <x:BoundField Width="80px" DataField="RewardGrade" DataFormatString="{0}" HeaderText="奖励级别" />
                                    <x:BoundField Width="80px" DataField="RewardClass" DataFormatString="{0}" HeaderText="奖励等级" />
                                    <x:BoundField Width="50px" DataField="CompleteType" DataFormatString="{0}" HeaderText="完成形式" />
                                    <x:BoundField Width="80px" DataField="WordCount" DataFormatString="{0}" HeaderText="字数" />
                                    <x:BoundField Width="50px" DataField="AutherCount" DataFormatString="{0}" HeaderText="参与人数" />
                                    <x:BoundField Width="100px" DataField="Auther1" DataFormatString="{0}" HeaderText="参与人1" />
                                    <x:BoundField Width="100px" DataField="Auther2" DataFormatString="{0}" HeaderText="参与人2" />
                                    <x:BoundField Width="100px" DataField="Auther3" DataFormatString="{0}" HeaderText="参与人3" />
                                    <x:BoundField Width="100px" DataField="Auther4" DataFormatString="{0}" HeaderText="参与人4" />
                                    <x:BoundField Width="100px" DataField="Auther5" DataFormatString="{0}" HeaderText="5人以上（含）" />
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
