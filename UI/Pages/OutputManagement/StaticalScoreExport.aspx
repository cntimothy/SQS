<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaticalScoreExport.aspx.cs"
    Inherits="SQS.UI.Pages.OutputManagement.StaticalResultExport" %>

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
                        <Columns>
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="部系（大单位）" />
                            <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="处室（单位）" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="论文得分" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="著作得分" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="课题得分" />
                            <x:BoundField Width="80px" DataField="Name" DataFormatString="{0}" HeaderText="总分" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="处室论文总分" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="处室著作总分" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="处室课题总分" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="处室总分" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="处室人均成绩" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="处室参研率" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="部系总成绩" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="部系论文人均分" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="部系人均分" />
                        </Columns>
                    </x:Grid>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
