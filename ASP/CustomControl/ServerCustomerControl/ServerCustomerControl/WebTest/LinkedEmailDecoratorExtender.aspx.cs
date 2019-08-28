using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using FirstCustomControl.Extender;

public partial class LinkedEmailDecorator_Extender : System.Web.UI.Page {
    FirstCustomControl.LinkedEmailExtender _emailLink = new FirstCustomControl.LinkedEmailExtender();
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void btnPost_Click(object sender, EventArgs e) {
        _emailLink.DisplayName = this.txtDisplayName.Text;
        _emailLink.Email = this.txtEmail.Text;
        _emailLink.Subject = this.txtSubject.Text;
        _emailLink.Body = this.txtBody.Text;
        LinkedEmailDecoratorExtender extender = new LinkedEmailDecoratorExtender(_emailLink);
        this.PlaceHolder1.Controls.Add(extender);
    }
}
