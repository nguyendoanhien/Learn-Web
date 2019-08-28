using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace FirstCustomControl {
    public class LinkedEmailExtender : HyperLink {
        [Localizable(true)]
        public string DisplayName {
            get {
                String s = (String)ViewState["DisplayName"];
                return ((s == null) ? "[DisplayName]" : s);
            }

            set {
                ViewState["DisplayName"] = value;
                ConstructLink();

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
                ConstructLink();

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
                ConstructLink();

            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string Body {
            get {
                String s = (String)ViewState["Body"];
                return ((s == null) ? string.Empty : s);
            }

            set {
                ViewState["Body"] = value;
                ConstructLink();
            }
        }
        private void ConstructLink() {
            this.Text = this.DisplayName;
            this.NavigateUrl = string.Format("mailto:{0}", this.Email);
            if (!string.IsNullOrEmpty(Subject)) {
                this.NavigateUrl = this.NavigateUrl + "?subject=" + this.Subject;
                this.NavigateUrl = this.NavigateUrl + "&body=" + this.Body;
            }
        }
    }
}
