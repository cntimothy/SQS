<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OfficeManagement.aspx.cs"
    Inherits="SQS.UI.Pages.BasicInformationManagement.OfficeManegement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <x:Button ID="Button_Refresh" runat="server" Text="刷新" OnClick="Button_Refresh_Click">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_AddDepart" runat="server" Text="新增部系">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_DeleteDepart" runat="server" Text="删除部系">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator3" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_AddOffice" runat="server" Text="新增处室">
                    </x:Button>
                    <x:ToolbarSeparator ID="ToolbarSeparator4" runat="server">
                    </x:ToolbarSeparator>
                    <x:Button ID="Button_DeleteOffice" runat="server" Text="删除处室">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="Panel">
                <Items>
                    <x:Grid ID="Grid1" runat="server" Title="部系、处室列表" Height="500px" AutoScroll="true"
                        AllowPaging="false" EnableCheckBoxSelect="false" DataKeyNames="Depart,Office"
                        EnableRowNumber="true">
                        <Columns>
                            <x:BoundField Width="100px" DataField="Depart" DataFormatString="{0}" HeaderText="部系" />
                            <x:BoundField Width="100px" DataField="Office" DataFormatString="{0}" HeaderText="处室" />
                        </Columns>
                    </x:Grid>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    <x:Window ID="Window1" runat="server" BodyPadding="5px" Height="200px" IsModal="true"
        Popup="false" Title="Window" Width="500px" EnableIFrame="true" IFrameUrl="about:blank" Target="Top">
    </x:Window>
    </form>
</body>
</html>
