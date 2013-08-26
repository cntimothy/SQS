<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="SQS.UI.HomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>科研成果查询统计系统</title>
    <link href="../css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" AutoSizePanelID="RegionPanel1" runat="server"></x:PageManager>
    <x:RegionPanel ID="RegionPanel1" ShowBorder="false" runat="server">
        <Regions>
            <x:Region ID="Region1" Margins="0 0 0 0" ShowBorder="false" Height="50px" ShowHeader="false"
                Position="Top" Layout="Fit" runat="server">
                <Items>
                    <x:ContentPanel ShowBorder="false" CssClass="jumbotron" ShowHeader="false" ID="ContentPanel1"
                        runat="server">
                        <div class="title">
                            <a href="./HomePage.aspx" style="color: #fff;">政治学院科研成果查询统计系统</a>
                        </div>
                        <div class="version">
                            <ul class="list">
                                <li class="list">
                                    <x:Label ID="UserName" runat="server" Label="Label" Text="" CssStyle="color: #fff;">
                                    </x:Label>
                                </li>
                                <li class="list">&nbsp|&nbsp</li>
                                <li class="list">
                                    <x:LinkButton ID="LoginOut" runat="server" Label="Label" Text="注销" ConfirmTitle="提示"
                                        ConfirmText="确认注销？" OnClick="LoginOut_Click">
                                    </x:LinkButton>
                                </li>
                            </ul>
                        </div>
                    </x:ContentPanel>
                </Items>
            </x:Region>
            <x:Region ID="Region2" Split="true" EnableSplitTip="true" CollapseMode="Mini" Width="150px"
                Margins="0 0 0 0" ShowHeader="false" Title="菜单" EnableLargeHeader="false" Icon="Outline"
                EnableCollapse="true" Layout="Fit" Position="Left" runat="server">
                <Toolbars>
                    <x:Toolbar ID="Toolbar1" Position="Top" runat="server">
                        <Items>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                        </Items>
                    </x:Toolbar>
                </Toolbars>
            </x:Region>
            <x:Region ID="mainRegion" ShowHeader="false" Layout="Fit" Margins="0 0 0 0" Position="Center"
                runat="server">
                <Items>
                    <x:TabStrip ID="mainTabStrip" EnableTabCloseMenu="true" ShowBorder="false" runat="server">
                        <Tabs>
                            <x:Tab ID="Tab1" Title="首页" Layout="Fit" Icon="House" runat="server">
                                <Toolbars>
                                    <x:Toolbar ID="Toolbar2" runat="server">
                                        <Items>
                                            <x:ToolbarFill ID="ToolbarFill2" runat="server">
                                            </x:ToolbarFill>
                                        </Items>
                                    </x:Toolbar>
                                </Toolbars>
                                <Items>
                                    <x:ContentPanel ID="ContentPanel2" ShowBorder="false" BodyPadding="10px" ShowHeader="false"
                                        AutoScroll="true" CssClass="intro" runat="server">
                                        <p>
                                            欢迎使用</p>
                                    </x:ContentPanel>
                                </Items>
                            </x:Tab>
                        </Tabs>
                    </x:TabStrip>
                </Items>
            </x:Region>
        </Regions>
    </x:RegionPanel>
    <asp:XmlDataSource ID="XmlDataSource_ForVisitor" runat="server" DataFile="../common/menu_for_visitor.xml">
    </asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlDataSource_ForManager" runat="server" DataFile="../common/menu_for_manager.xml">
    </asp:XmlDataSource>
    </form>
    <script src="../js/default.js" type="text/javascript"></script>
</body>
</html>
