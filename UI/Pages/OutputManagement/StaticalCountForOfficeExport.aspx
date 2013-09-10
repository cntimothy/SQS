<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaticalCountForOfficeExport.aspx.cs"
    Inherits="SQS.UI.Pages.OutputManagement.StaticalCountExport" %>

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
                    <x:DropDownList ID="DropDownList_StartYear" runat="server" Label="Label" Width="120px">
                        <x:ListItem EnableSelect="false" Selected="true" Text="选择开始年份" Value="0" />
                    </x:DropDownList>
                    <x:DropDownList ID="DropDownList_StartMonth" runat="server" Label="Label" Width="50px">
                        <x:ListItem EnableSelect="true" Selected="true" Text="1月" Value="1" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="2月" Value="2" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="3月" Value="3" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="4月" Value="4" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="5月" Value="5" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="6月" Value="6" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="7月" Value="7" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="8月" Value="8" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="9月" Value="9" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="10月" Value="10" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="11月" Value="11" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="12月" Value="12" />
                    </x:DropDownList>
                    <x:Label ID="Label1" runat="server" Label="Label" Text="到" Width="40px">
                    </x:Label>
                    <x:DropDownList ID="DropDownList_StopYear" runat="server" Label="Label" Width="120px">
                        <x:ListItem EnableSelect="false" Selected="true" Text="选择结束年份" Value="0" />
                    </x:DropDownList>
                    <x:DropDownList ID="DropDownList_StopMonth" runat="server" Label="Label" Width="50px">
                        <x:ListItem EnableSelect="true" Selected="false" Text="1月" Value="1" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="2月" Value="2" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="3月" Value="3" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="4月" Value="4" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="5月" Value="5" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="6月" Value="6" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="7月" Value="7" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="8月" Value="8" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="9月" Value="9" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="10月" Value="10" />
                        <x:ListItem EnableSelect="true" Selected="false" Text="11月" Value="11" />
                        <x:ListItem EnableSelect="true" Selected="true" Text="12月" Value="12" />
                    </x:DropDownList>
                    <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_GetResult" runat="server" Text="生成总表">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_Export" runat="server" Text="导出">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel">
                <Items>
                    <x:Grid ID="Grid1" runat="server" Title="输出总表" AutoScroll="true" Height="500px">
                        <GroupColumns>
                            <x:GridGroupColumn HeaderText="单位" TextAlign="Center">
                                <Columns>
                                    <x:BoundField Width="150px" DataField="Depart" HeaderText="部系" />
                                    <x:BoundField Width="150px" DataField="Office" HeaderText="处室" />
                                </Columns>
                            </x:GridGroupColumn>
                            <x:GridGroupColumn HeaderText="论文" TextAlign="Center">
                                <Columns>
                                    <x:BoundField Width="80px" DataField="PaperPublishGrade1" HeaderText="发表级别1" />
                                    <x:BoundField Width="80px" DataField="PaperPublishGrade2" HeaderText="发表级别2" />
                                    <x:BoundField Width="80px" DataField="PaperPublishGrade3" HeaderText="发表级别3" />
                                    <x:BoundField Width="80px" DataField="PaperPublishGrade4" HeaderText="发表级别4" />
                                    <x:BoundField Width="80px" DataField="PaperRewardGrade1" HeaderText="奖励级别1" />
                                    <x:BoundField Width="80px" DataField="PaperRewardGrade2" HeaderText="奖励级别2" />
                                    <x:BoundField Width="80px" DataField="PaperRewardGrade3" HeaderText="奖励级别3" />
                                    <x:BoundField Width="80px" DataField="PaperRewardClass1" HeaderText="奖励等级1" />
                                    <x:BoundField Width="80px" DataField="PaperRewardClass2" HeaderText="奖励等级2" />
                                    <x:BoundField Width="80px" DataField="PaperRewardClass3" HeaderText="奖励等级3" />
                                </Columns>
                            </x:GridGroupColumn>
                            <x:GridGroupColumn HeaderText="著作" TextAlign="Center">
                                <Columns>
                                    <x:BoundField Width="80px" DataField="BookPublishGrade1" HeaderText="发行级别1" />
                                    <x:BoundField Width="80px" DataField="BookPublishGrade2" HeaderText="发行级别2" />
                                    <x:BoundField Width="80px" DataField="BookPublishGrade3" HeaderText="发行级别3" />
                                    <x:BoundField Width="80px" DataField="BookRewardGrade1" HeaderText="奖励级别1" />
                                    <x:BoundField Width="80px" DataField="BookRewardGrade2" HeaderText="奖励级别2" />
                                    <x:BoundField Width="80px" DataField="BookRewardGrade3" HeaderText="奖励级别3" />
                                    <x:BoundField Width="80px" DataField="BookRewardClass1" HeaderText="奖励等级1" />
                                    <x:BoundField Width="80px" DataField="BookRewardClass2" HeaderText="奖励等级2" />
                                    <x:BoundField Width="80px" DataField="BookRewardClass3" HeaderText="奖励等级3" />
                                </Columns>
                            </x:GridGroupColumn>
                            <x:GridGroupColumn HeaderText="课题" TextAlign="Center">
                                <Columns>
                                    <x:BoundField Width="80px" DataField="TopicPublishGrade1" HeaderText="发行级别1" />
                                    <x:BoundField Width="80px" DataField="TopicPublishGrade2" HeaderText="发行级别2" />
                                    <x:BoundField Width="80px" DataField="TopicPublishGrade3" HeaderText="发行级别3" />
                                    <x:BoundField Width="80px" DataField="TopicPublishGrade4" HeaderText="发行级别4" />
                                    <x:BoundField Width="80px" DataField="TopicRewardGrade1" HeaderText="奖励级别1" />
                                    <x:BoundField Width="80px" DataField="TopicRewardGrade2" HeaderText="奖励级别2" />
                                    <x:BoundField Width="80px" DataField="TopicRewardGrade3" HeaderText="奖励级别3" />
                                    <x:BoundField Width="80px" DataField="TopicRewardClass1" HeaderText="奖励等级1" />
                                    <x:BoundField Width="80px" DataField="TopicRewardClass2" HeaderText="奖励等级2" />
                                    <x:BoundField Width="80px" DataField="TopicRewardClass3" HeaderText="奖励等级3" />
                                </Columns>
                            </x:GridGroupColumn>
                        </GroupColumns>
                    </x:Grid>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
