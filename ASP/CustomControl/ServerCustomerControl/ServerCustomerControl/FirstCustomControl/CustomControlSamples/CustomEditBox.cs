using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTMC = System.Web.UI.HtmlControls;

namespace FirstCustomControl {
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:CustomEditBox runat=\"server\" Label=\"[Label]\" Text=\"[Text]\"></{0}:CustomEditBox>")]
    public class CustomEditBox : CompositeControl, IPostBackDataHandler {
        public event EventHandler OnTextChanged;
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("1")]
        [Localizable(true)]
        public int NoOfSpaces {
            get {
                if (ViewState["NoOfSpaces"] == null) {
                    ViewState["NoOfSpaces"] = 0;
                    return 0;
                }
                int intSpaces = -1;
                int.TryParse(ViewState["NoOfSpaces"].ToString(), out intSpaces);
                if (intSpaces != -1) return intSpaces;
                else {
                    throw new InvalidOperationException("invalid value");
                }
            }

            set {
                ViewState["NoOfSpaces"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text {
            get {
                String s = ViewState["Text"] as string;
                return ((s == null) ? "[Text]" : s);
            }

            set {
                if (ViewState["Text"] != null && (ViewState["Text"].ToString() != value))
                    if (this.Text != this._innerTextControl.Text) 
                        OnTextChanged(this, EventArgs.Empty);
                ViewState["Text"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Label {
            get {
                String s = ViewState["Label"] as string;
                return ((s == null) ? "[Label]" : s);
            }

            set {
                ViewState["Label"] = value;
            }
        }

        TextBox _innerTextControl = new TextBox();
        HTMC.HtmlGenericControl _innerLabel = new System.Web.UI.HtmlControls.HtmlGenericControl("label");
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }
        protected override void OnInit(EventArgs e) {
            InitControls();
            base.OnInit(e);
        }
        protected override void CreateChildControls() {
            BuildControl();
            base.CreateChildControls();
        }

        private void InitControls() {
            _innerTextControl.EnableViewState = true;
            _innerTextControl.ID = "Inner_TextBox";
            _innerLabel.EnableViewState = true;
            _innerLabel.ID = "Inner_Label";
        }

        private void BuildControl() {
            this.Controls.Clear();
            _innerTextControl.Text = this.Text;
            _innerLabel.InnerText = this.Label;
            _innerLabel.Attributes.Add("for", this._innerTextControl.ClientID);
            this.Controls.Add(this._innerLabel);
            Literal lit = GetSpaces();
            this.Controls.Add(lit);
            this.Controls.Add(this._innerTextControl);
            Literal hidControl = new Literal(); // to raise LoadPostData
            hidControl.Text = String.Format("<input type=hidden name='{0}' value = '{0}'>", this.UniqueID);
            this.Controls.Add(hidControl);
            ClearChildViewState();
        }
        private Literal GetSpaces() {
            string litral = string.Empty;
            for (int i = 0; i < this.NoOfSpaces; i++) {
                litral += "&nbsp;";
            }
            Literal lit = new Literal();
            lit.Text = litral;
            return lit;
        }
        protected override void OnPreRender(EventArgs e) {
            ChildControlsCreated = false;
            EnsureChildControls();
            base.OnPreRender(e);
        }
        #region IPostBackDataHandler Members

        public bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection) {

            if (postDataKey == this.UniqueID) {
                foreach (string key in postCollection.Keys) {
                    if (key.ToLower().Contains(this._innerTextControl.UniqueID.ToLower())) {
                        this.Text = postCollection[key];
                    }
                }
            }
            return false;
        }

        public void RaisePostDataChangedEvent() {
            return;
        }

        #endregion
    }
}
