<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SQS.UI.Pages.SearchManagement.Search" %>

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
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel">
                <Items>
                    <x:Form ID="Form2" runat="server" BodyPadding="5px" Title="搜索条件" LabelWidth="150px">
                        <Rows>
                            <x:FormRow ID="FormRow1" runat="server">
                                <Items>
                                    <x:TextBox ID="TextBox_Name" runat="server" Label="姓名" Text="" EmptyText="请输入姓名">
                                    </x:TextBox>
                                    <x:TextBox ID="TextBox_BookName" runat="server" Label="著作、论文、课题名称" Text="" EmptyText="请输入著作名称">
                                    </x:TextBox>
                                </Items>
                            </x:FormRow>
                            <x:FormRow ID="FormRow3" runat="server">
                                <Items>
                                    <x:DropDownList ID="DropDownList_Depart" runat="server" Label="部系">
                                        <x:ListItem Selected="true" EnableSelect="true" Text="所有部系" Value="0" />
                                    </x:DropDownList>
                                    <x:DropDownList ID="DropDownList_Office" runat="server" Label="处室" Enabled="false">
                                        <x:ListItem Selected="true" EnableSelect="true" Text="所有处室" Value="0" />
                                    </x:DropDownList>
                                </Items>
                            </x:FormRow>
                            <x:FormRow ID="FormRow2" runat="server">
                                <Items>
                                    <x:DatePicker ID="DatePicker_PublishDateStart" runat="server" Label="出版、发表、结题时间 从" EmptyText="点击右边图标选择日期"
                                        DateFormatString="yyyy-m">
                                    </x:DatePicker>
                                    <x:DatePicker ID="DatePicker_PublishDateStop" runat="server" Label="到" EmptyText="点击右边图标选择日期"
                                        DateFormatString="yyyy-m">
                                    </x:DatePicker>
                                </Items>
                            </x:FormRow>
                            <x:FormRow>
                                <Items>
                                    <x:Button ID="Button_Search" runat="server" Text="搜索">
                                    </x:Button>
                                </Items>
                            </x:FormRow>
                        </Rows>
                    </x:Form>
                    <x:Grid ID="Grid1" runat="server" Title="著作统计表" EnableRowNumber="true" AllowPaging="true"
                        PageSize="5" Height="200px" AutoScroll="true">
                        <Columns>
                            <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="部系单位" />
                            <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="处室单位" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                            <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="著作名称" />
                            <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="出版社" />
                            <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="出版时间（年月）" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="发行级别" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="奖励级别" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="奖励等级" />
                            <x:BoundField Width="50px" DataField="Name" DataFormatString="{0}" HeaderText="字数" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="编写人数" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="编1" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="编2" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="编3" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="编4" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="编5以上（含）" />
                        </Columns>
                    </x:Grid>
                    <x:Grid ID="Grid2" runat="server" Title="论文统计表" EnableRowNumber="true" AllowPaging="true"
                        PageSize="5" Height="200px" AutoScroll="true">
                        <Columns>
                            <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="部系单位" />
                            <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="处室单位" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                            <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="论文名称" />
                            <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="发表刊物、会议或文集名称" />
                            <x:BoundField Width="150px" DataField="Name" DataFormatString="{0}" HeaderText="发表时间（年月）" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="发表级别" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="奖励级别" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="奖励等级" />
                            <x:BoundField Width="50px" DataField="Name" DataFormatString="{0}" HeaderText="字数" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="作者人数" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="第1作者" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="第2作者" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="第3作者" />
                        </Columns>
                    </x:Grid>
                    <x:Grid ID="Grid3" runat="server" Title="课题统计表" EnableRowNumber="true" AllowPaging="true"
                        PageSize="5" Height="200px" AutoScroll="true">
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
    </form>
</body>
</html>
