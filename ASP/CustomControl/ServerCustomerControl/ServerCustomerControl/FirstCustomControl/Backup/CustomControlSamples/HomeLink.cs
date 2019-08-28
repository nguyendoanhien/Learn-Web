using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace FirstCustomControl {
    public class HomeLink :HyperLink{
        protected override void OnPreRender(EventArgs e) {
            EnsureChildControls();
            this.Text = "Home";
            this.NavigateUrl = GetHomePage();
            base.OnPreRender(e);
        }

        private string GetHomePage() {
            return "~/";
        }
    }
}
