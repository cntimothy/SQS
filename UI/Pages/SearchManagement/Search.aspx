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
                    <x:Form ID="Form2" runat="server" BodyPadding="0px" Title="Form" ShowBorder="false"
                        ShowHeader="false" Width="700px" >
                        <Rows>
                            <x:FormRow ID="FormRow1" runat="server">
                                <Items>
                                    <x:TextBox ID="TextBox1" runat="server" Label="请输入姓名" Text="">
                                    </x:TextBox>
                                    <x:DropDownList ID="DropDownList1" runat="server" Label="请选择年份">
                                    </x:DropDownList>
                                </Items>
                            </x:FormRow>
                        </Rows>
                    </x:Form>
                    <x:Grid ID="Grid1" runat="server" Title="著作查询结果">
                        <Columns>
                        </Columns>
                    </x:Grid>
                    <x:Grid ID="Grid2" runat="server" Title="论文查询结果">
                        <Columns>
                        </Columns>
                    </x:Grid>
                    <x:Grid ID="Grid3" runat="server" Title="课题查询结果">
                        <Columns>
                        </Columns>
                    </x:Grid>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
