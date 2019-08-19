<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomEdit.aspx.cs" Inherits="CustomEdit" %>

<%@ Register Assembly="FirstCustomControl" Namespace="FirstCustomControl" TagPrefix="FC" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Custom edit box, as composite control</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 72px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <FC:HomeLink ID="HomeLink1" runat="server"></FC:HomeLink>
    <div>
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                <span lang="en-au">Label</span>
            </td>
            <td>
                <asp:TextBox ID="txtLabel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <span lang="en-au">Text</span>
            </td>
            <td>
                <asp:TextBox ID="txtText" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <span lang="en-au">Spaces</span>
            </td>
            <td>
                <asp:DropDownList ID="drpSpaces" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;
            </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <FC:CustomEditBox ID="CustomEditBox1" runat="server" Label="[Label]" 
                    Text="[Text]" onontextchanged="CustomEditBox1_OnTextChanged" />   
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <span lang="en-au">Track Changes </span>
                <asp:TextBox ID="txtChanges" runat="server" Width="552px"></asp:TextBox>
            </td>
        </tr>
    </table>
            <asp:Button ID="Button1" runat="server" Text="Test ViewState round trip" />
    
    </form>
</body>
</html>

