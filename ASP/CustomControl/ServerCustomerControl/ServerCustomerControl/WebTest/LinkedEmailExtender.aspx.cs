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

public partial class LinkedEmailExtender : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void btnPost_Click(object sender, EventArgs e) {
        this.LinkedEmailExtender1.DisplayName = this.txtDisplayName.Text;
        this.LinkedEmailExtender1.Email = this.txtEmail.Text;
        this.LinkedEmailExtender1.Subject = this.txtSubject.Text;
        this.LinkedEmailExtender1.Body = this.txtBody.Text;
    }
}
