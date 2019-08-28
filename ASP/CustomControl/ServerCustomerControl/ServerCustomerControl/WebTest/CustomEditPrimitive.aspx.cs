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

public partial class CustomEditPrimitive : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        this.txtChanges.Text ="old value:" +this.CustomEditBoxPrimitive1.Text;
  
    }
    protected void btnSubmit_Click(object sender, EventArgs e) {
        this.CustomEditBoxPrimitive1.Text = this.txtText.Text;
        this.CustomEditBoxPrimitive1.Label = this.txtLabel.Text;
        this.CustomEditBoxPrimitive1.NoOfSpaces = int.Parse(this.drpSpaces.SelectedValue);
        this.txtChanges.Text +=" new value:"+ this.CustomEditBoxPrimitive1.Text;

    }
}
