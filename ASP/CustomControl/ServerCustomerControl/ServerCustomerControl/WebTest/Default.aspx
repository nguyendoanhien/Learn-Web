<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"
    Theme="App_Theme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Control</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 1px solid #000066;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table align="left" cellpadding="3" cellspacing="3" class="style1">
        <tr>
            <td>
                <span lang="en-au">Sample</span>
            </td>
            <td>
                Points of interest
            </td>
            <td>
                Sample Page
            </td>
        </tr>
        <tr>
            <td>
                Custom Email Link
            </td>
            <td>
                This sample control is just inherit from WebControl Class, will create a read only
                email hyperlink that embed information about the email, display name, email subject
                and email body, this sample will demonstrate<span lang="en-au">:</span><br />
                <br />
                <li>Using ViewState to save all control exposed property state, in the round trip.
                </li>
                <li>Using Design mode rendering, different to the runtime rendering.</li>
                <li>Using custom icon, in the toolbox.</li>
                <li>Using Tag prefix format, for control registration.</li>
                <li>Using other server controls internally, to simplify the custom rendering.</li>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CustomEmail.aspx">Custom Email Link</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                Primitive Custom Edit Box
            </td>
            <td>
                This sample control is not composite control (not inherited from CompositeControl
                class), however most of the composite control functionality, and postback information
                was implemented using the primitive concepts of the webcontrol and the HttpContext
                information, this sample will demonstrate<span lang="en-au">:</span><br />
                <br />
                <li>Creating postback data handler to track the state , without implementing </li>
                IPostBackDataHandler.<li>Creating design time support, without implementing ICompositeControlDesignerAccessor.</li>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/CustomEditPrimitive.aspx">Custom Edit Box Primitive</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                Custom Edit Box
            </td>
            <td>
                This sample control is composite control (inherit from CompositeControl) this sample
                will demonstrate<span lang="en-au">:</span><br />
                <br />
                <li>Creating postback data handler to track the state , with implementing IPostBackDataHandler<span
                    lang="en-au">.</span></li>
                <li>Creating native design time support<span lang="en-au">.</span></li>
                <li><span lang="en-au">Creating Raise Events, for tracking state changes</span></li>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/CustomEdit.aspx">Custom 
                Edit Box</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                Linked Email Exemder
            </td>
            <td>
                This sample control is <span lang="en-au">extending, through direct inheriting from
                    HyperLink control</span><br />
            </td>
            <td>
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/LinkedEmailExtender.aspx">Linked email extender</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                Linked Email Exemder (decorator pattern)
            </td>
            <td>
                This sample control is extending, through decorator pattern, and add a new functionality to any other
                control not just the Hyper link<br />
            </td>
            <td>
                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/LinkedEmailDecoratorExtender.aspx">Linked email extender Decorator</asp:HyperLink>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
