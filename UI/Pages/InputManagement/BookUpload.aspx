<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookUpload.aspx.cs" Inherits="SQS.UI.Pages.InputManagement.BookUpload" %>

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
                            <x:ToolbarSeparator ID="ToolbarSeparator3" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Delete" runat="server" Text="删除所选" OnClick="Button_Delete_Click">
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
                            <x:Form ID="Form2" runat="server" BodyPadding="5px" Title="搜索条件" LabelWidth="80px"
                                LabelAlign="Right">
                                <Rows>
                                    <x:FormRow ID="FormRow1" runat="server">
                                        <Items>
                                            <x:TextBox ID="TextBox_Name" runat="server" Label="姓名" Text="" EmptyText="请输入姓名">
                                            </x:TextBox>
                                            <x:TextBox ID="TextBox_BookName" runat="server" Label="著作名称" Text="" EmptyText="请输入著作名称">
                                            </x:TextBox>
                                        </Items>
                                    </x:FormRow>
                                    <x:FormRow ID="FormRow3" runat="server">
                                        <Items>
                                            <x:DropDownList ID="DropDownList_Depart" runat="server" Label="部系" AutoPostBack="true"
                                                OnSelectedIndexChanged="DropDownList_Depart_SelectedChanged">
                                                <x:ListItem Selected="true" EnableSelect="true" Text="所有部系" Value="0" />
                                            </x:DropDownList>
                                            <x:DropDownList ID="DropDownList_Office" runat="server" Label="处室" Enabled="false">
                                                <x:ListItem Selected="true" EnableSelect="true" Text="所有处室" Value="0" />
                                            </x:DropDownList>
                                        </Items>
                                    </x:FormRow>
                                    <x:FormRow ID="FormRow2" runat="server">
                                        <Items>
                                            <x:DatePicker ID="DatePicker_PublishDateStart" runat="server" Label="出版时间 从" EmptyText="点击右边图标选择日期"
                                                DateFormatString="yyyy-MM">
                                            </x:DatePicker>
                                            <x:DatePicker ID="DatePicker_PublishDateStop" runat="server" Label="到" EmptyText="点击右边图标选择日期"
                                                DateFormatString="yyyy-MM">
                                            </x:DatePicker>
                                        </Items>
                                    </x:FormRow>
                                    <x:FormRow ID="FormRow4" runat="server">
                                        <Items>
                                            <x:DatePicker ID="DatePicker_CreateDateStart" runat="server" Label="上传时间 从" EmptyText="点击右边图标选择日期"
                                                DateFormatString="yyyy-MM-dd">
                                            </x:DatePicker>
                                            <x:DatePicker ID="DatePicker_CreateDateStop" runat="server" Label="到" EmptyText="点击右边图标选择日期"
                                                DateFormatString="yyyy-MM-dd">
                                            </x:DatePicker>
                                        </Items>
                                    </x:FormRow>
                                    <x:FormRow ID="FormRow5" runat="server">
                                        <Items>
                                            <x:DatePicker ID="DatePicker_UpdateDateStart" runat="server" Label="更新时间 从" EmptyText="点击右边图标选择日期"
                                                DateFormatString="yyyy-MM-dd">
                                            </x:DatePicker>
                                            <x:DatePicker ID="DatePicker_UpdateDateStop" runat="server" Label="到" EmptyText="点击右边图标选择日期"
                                                DateFormatString="yyyy-MM-dd">
                                            </x:DatePicker>
                                        </Items>
                                    </x:FormRow>
                                    <x:FormRow>
                                        <Items>
                                            <x:Button ID="Button_Search" runat="server" Text="搜索" OnClick="Button_Search_Click">
                                            </x:Button>
                                        </Items>
                                    </x:FormRow>
                                </Rows>
                            </x:Form>
                            <x:Grid ID="Grid1" runat="server" Title="著作统计表" EnableRowNumber="true" AllowPaging="true"
                                PageSize="20" Height="520px" AutoScroll="true" DataKeyNames="ID" EnableMultiSelect="true"
                                CheckBoxSelectOnly="true" EnableCheckBoxSelect="true" OnPageIndexChange="Grid1_PageIndexChange"
                                ClearSelectedRowsAfterPaging="false">
                                <Columns>
                                    <x:BoundField Width="150px" DataField="ID" DataFormatString="{0}" HeaderText="ID"
                                        Hidden="true" />
                                    <x:BoundField Width="150px" DataField="Depart" DataFormatString="{0}" HeaderText="部系单位" />
                                    <x:BoundField Width="150px" DataField="Office" DataFormatString="{0}" HeaderText="处室单位" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                                    <x:BoundField Width="200px" DataField="BookName" DataFormatString="{0}" HeaderText="著作名称" />
                                    <x:BoundField Width="200px" DataField="Press" DataFormatString="{0}" HeaderText="出版社" />
                                    <x:BoundField Width="150px" DataField="PublishDate" DataFormatString="{0}" HeaderText="出版时间（年月）" />
                                    <x:BoundField Width="80px" DataField="PublishGrade" DataFormatString="{0}" HeaderText="发行级别" />
                                    <x:BoundField Width="80px" DataField="RewardGrade" DataFormatString="{0}" HeaderText="奖励级别" />
                                    <x:BoundField Width="80px" DataField="RewardClass" DataFormatString="{0}" HeaderText="奖励等级" />
                                    <x:BoundField Width="50px" DataField="WordCount" DataFormatString="{0}" HeaderText="字数" />
                                    <x:BoundField Width="80px" DataField="AutherCount" DataFormatString="{0}" HeaderText="编写人数" />
                                    <x:BoundField Width="100px" DataField="Auther1" DataFormatString="{0}" HeaderText="编1" />
                                    <x:BoundField Width="100px" DataField="Auther2" DataFormatString="{0}" HeaderText="编2" />
                                    <x:BoundField Width="100px" DataField="Auther3" DataFormatString="{0}" HeaderText="编3" />
                                    <x:BoundField Width="100px" DataField="Auther4" DataFormatString="{0}" HeaderText="编4" />
                                    <x:BoundField Width="100px" DataField="Auther5" DataFormatString="{0}" HeaderText="编5以上（含）" />
                                    <x:WindowField ColumnID="WindowField_Modify" TextAlign="Center" Width="80px" WindowID="Window_Modify"
                                        HeaderText="操作" Text="修改" ToolTip="修改项目" Title="操作" IFrameUrl="iframe_ModifyBookInformation.aspx"
                                        DataIFrameUrlFields="ID" DataIFrameUrlFormatString="iframe_ModifyBookInformation.aspx?id={0}" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    <x:HiddenField ID="hfSelectedIDS" runat="server">
    </x:HiddenField>
    <x:Window ID="Window_Modify" runat="server" BodyPadding="5px" IsModal="true" Popup="false"
        Title="修改" Width="500px" Height="400px" EnableClose="false" Target="Top" EnableResize="true"
        EnableIFrame="true" IFrameUrl="about:blank">
    </x:Window>
    </form>
</body>
</html>
