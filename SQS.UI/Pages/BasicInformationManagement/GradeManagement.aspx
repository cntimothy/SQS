<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeManagement.aspx.cs"
    Inherits="SQS.UI.Pages.BasicInformationManagement.GradeManegement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel7" />
    <x:Panel ID="Panel7" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <x:Button ID="Button_Refresh" runat="server" Text="刷新" OnClick="Button_Refresh_Click">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel1" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel" AutoScroll="true" Layout="Table" TableConfigColumns="3">
                <Items>
                    <x:Panel ID="Panel3" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="论文发表级别" Width="300px" Height="400px">
                        <Items>
                            <x:Grid ID="Grid_PublishGradeForPaper" runat="server" Title="Grid" AllowPaging="false"
                                EnableRowNumber="true" ShowHeader="false">
                                <Columns>
                                    <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="ID"
                                        Hidden="true" />
                                    <x:BoundField Width="100px" ExpandUnusedSpace="true" DataField="Name" DataFormatString="{0}"
                                        HeaderText="名称" />
                                    <x:WindowField ColumnID="WindowField_Update" TextAlign="Center" Width="80px" WindowID="Window_Update"
                                        Text="修改" ToolTip="修改名称" Title="操作" IFrameUrl="iframe_UpdateGrade.aspx" DataIFrameUrlFields="ID"
                                        DataIFrameUrlFormatString="iframe_UpdateGrade.aspx?id={0}&source=paper" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="著作发行级别" Width="300px" Height="400px">
                        <Items>
                            <x:Grid ID="Grid_PublishGradeForBook" runat="server" Title="Grid" AllowPaging="false"
                                EnableRowNumber="true" ShowHeader="false">
                                <Columns>
                                    <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="ID"
                                        Hidden="true" />
                                    <x:BoundField Width="100px" ExpandUnusedSpace="true" DataField="Name" DataFormatString="{0}"
                                        HeaderText="名称" />
                                    <x:WindowField ColumnID="WindowField_Update" TextAlign="Center" Width="80px" WindowID="Window_Update"
                                        Text="修改" ToolTip="修改名称" Title="操作" IFrameUrl="iframe_UpdateGrade.aspx" DataIFrameUrlFields="ID"
                                        DataIFrameUrlFormatString="iframe_UpdateGrade.aspx?id={0}&source=book" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel4" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="课题级别" Width="300px" Height="400px">
                        <Items>
                            <x:Grid ID="Grid_TopicGrade" runat="server" Title="Grid" AllowPaging="false" EnableRowNumber="true"
                                ShowHeader="false">
                                <Columns>
                                    <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="ID"
                                        Hidden="true" />
                                    <x:BoundField Width="100px" ExpandUnusedSpace="true" DataField="Name" DataFormatString="{0}"
                                        HeaderText="名称" />
                                    <x:WindowField ColumnID="WindowField_Update" TextAlign="Center" Width="80px" WindowID="Window_Update"
                                        Text="修改" ToolTip="修改名称" Title="操作" IFrameUrl="iframe_UpdateGrade.aspx" DataIFrameUrlFields="ID"
                                        DataIFrameUrlFormatString="iframe_UpdateGrade.aspx?id={0}&source=topic" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel5" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="奖励级别" Width="300px" Height="400px">
                        <Items>
                            <x:Grid ID="Grid_RewardGrade" runat="server" Title="Grid" AllowPaging="false" EnableRowNumber="true"
                                ShowHeader="false">
                                <Columns>
                                    <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="ID"
                                        Hidden="true" />
                                    <x:BoundField Width="100px" ExpandUnusedSpace="true" DataField="Name" DataFormatString="{0}"
                                        HeaderText="名称" />
                                    <x:WindowField ColumnID="WindowField_Update" TextAlign="Center" Width="80px" WindowID="Window_Update"
                                        Text="修改" ToolTip="修改名称" Title="操作" IFrameUrl="iframe_UpdateGrade.aspx" DataIFrameUrlFields="ID"
                                        DataIFrameUrlFormatString="iframe_UpdateGrade.aspx?id={0}&source=rewardgrade" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel6" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="奖励等级" Width="300px" Height="400px">
                        <Items>
                            <x:Grid ID="Grid_RewardClass" runat="server" Title="Grid" AllowPaging="false" EnableRowNumber="true"
                                ShowHeader="false">
                                <Columns>
                                    <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="ID"
                                        Hidden="true" />
                                    <x:BoundField Width="100px" ExpandUnusedSpace="true" DataField="Name" DataFormatString="{0}"
                                        HeaderText="名称" />
                                    <x:WindowField ColumnID="WindowField_Update" TextAlign="Center" Width="80px" WindowID="Window_Update"
                                        Text="修改" ToolTip="修改名称" Title="操作" IFrameUrl="iframe_UpdateGrade.aspx" DataIFrameUrlFields="ID"
                                        DataIFrameUrlFormatString="iframe_UpdateGrade.aspx?id={0}&source=rewardclass" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    <x:Window ID="Window_Update" runat="server" BodyPadding="5px" Height="200px" IsModal="true"
        Popup="false" Title="修改" Width="500px" EnableIFrame="true" IFrameUrl="about:blank"
        Target="Top">
    </x:Window>
    </form>
</body>
</html>
