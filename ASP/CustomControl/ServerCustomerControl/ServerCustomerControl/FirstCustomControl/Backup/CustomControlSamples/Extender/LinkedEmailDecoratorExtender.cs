using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace FirstCustomControl.Extender {
    public class LinkedEmailDecoratorExtender:WebControl {
        WebControl _baseControl = null;
        public LinkedEmailDecoratorExtender(WebControl baseControl) {
            _baseControl = baseControl;
        }
        protected override void Render(System.Web.UI.HtmlTextWriter writer) {
            writer.Write("<div {0}={1}>", "style", "'border: medium dotted #FF00FF; padding: 5px; margin: 5px; width: 150px; height: 30px; font-family: Arial; font-weight: bold; vertical-align: middle; text-align: center;'");
            _baseControl.RenderControl(writer);
            writer.Write("</div>");
        }
    }
}
