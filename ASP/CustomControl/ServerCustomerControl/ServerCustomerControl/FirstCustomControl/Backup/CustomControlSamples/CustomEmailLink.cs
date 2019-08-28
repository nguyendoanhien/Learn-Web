using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstCustomControl {
    /// <summary>
    /// This sample explain these feature
    /// 1-Save custom control state in view state
    /// 2-Using diffrent methods for rendering, design and runtime
    /// 3-Using Category attribute for bettwr organising
    /// </summary>
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:CustomEmailLink runat=server></{0}:CustomEmailLink>")]
    public class CustomEmailLink : WebControl {
        [Bindable(true)]
        [Category("Appearance")]
        
        [Localizable(true)]
        public string DisplayName {
            get {
                String s = (String)ViewState["DisplayName"];
                return ((s == null) ? "[DisplayName]" : s);
            }

            set {
                ViewState["DisplayName"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string Email {
            get {
                String s = (String)ViewState["Email"];
                return ((s == null) ? "[Email]" : s);
            }

            set {
                ViewState["Email"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string Subject {
            get {
                String s = (String)ViewState["Subject"];
                return ((s == null) ? string.Empty : s);
            }

            set {
                ViewState["Subject"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string Body {
            get {
                String s = (String)ViewState["Body"];
                return ((s == null) ?string.Empty : s);
            }

            set {
                ViewState["Body"] = value;
            }
        }
        protected override void RenderContents(HtmlTextWriter output) {
            if (this.DesignMode) { RenderDesign(output); } else {
                if (this.Visible) {
                    RenderRuntime(output);
                }
                else {
                    return;
                }
            }
        }

        private void RenderRuntime(HtmlTextWriter output) {
            HyperLink link = new HyperLink();
            link.ID = this.ID;
            link.Text = this.DisplayName;
            link.NavigateUrl=string.Format("mailto:{0}",this.Email);
            if (!string.IsNullOrEmpty(Subject)) {
                link.NavigateUrl = link.NavigateUrl + "?subject=" + this.Subject;
                link.NavigateUrl = link.NavigateUrl + "&body=" + this.Body;
            }
            link.RenderControl(output);
        }

        private void RenderDesign(HtmlTextWriter output) {
            output.Write("Display Name:{0}<br/>Email:{1}<br/>Subject:{2}<br/>Body:{3}", this.DisplayName, this.Email,this.Subject,this.Body);
        }

        
    }
}
