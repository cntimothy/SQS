<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaticalResultExport.aspx.cs"
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
                    <x:Button ID="Button1" runat="server" Text="刷新">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button2" runat="server" Text="导出">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel">
                <Items>
                    <x:Grid ID="Grid1" runat="server" Title="输出总表">
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
