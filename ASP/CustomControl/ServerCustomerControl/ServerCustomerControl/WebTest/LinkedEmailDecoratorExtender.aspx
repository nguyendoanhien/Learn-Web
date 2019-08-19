<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinkedEmailDecoratorExtender.aspx.cs"
    Inherits="LinkedEmailDecorator_Extender" %>

<%@ Register Assembly="FirstCustomControl" Namespace="FirstCustomControl" TagPrefix="FC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Linked email extender decorator</title>
</head>
<body>
    <form id="form1" runat="server">
    <FC:HomeLink ID="HomeLink1" runat="server"></FC:HomeLink>
    
    <table class="style1">
        <tr>
            <td class="style2">
                <span lang="en-au">Display Name</span>
            </td>
            <td>
                <asp:TextBox ID="txtDisplayName" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <span lang="en-au">Email</span>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <span lang="en-au">subject</span>
            </td>
            <td>
                <asp:TextBox ID="txtSubject" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <span lang="en-au">Body</span>
            </td>
            <td>
                <asp:TextBox ID="txtBody" runat="server" Height="119px" TextMode="MultiLine" Width="255px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnPost" runat="server" OnClick="btnPost_Click" Text="Generate Link" />
    <br />
    <br />
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <br />
    <br />
    </form>
</body>
</html>
