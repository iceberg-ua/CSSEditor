using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSEditor
{
    public partial class Form1 : Form
    {
        IHTMLDocument2 _doc;
        IHTMLStyleSheet _style;

        string _defaultHTML = @"<body><h1>Title</h1><hr>
<ul>
<li>qwe</li>
<li>asd </li>
<li>zxc</li>
</ul>
<ol>
<li>123</li>
<li>456</li>
<li>789</li>
</ol>
</body>";

        HTMLCanvas _htmlCanvas = new HTMLCanvas();

        public Form1()
        {
            InitializeComponent();

            _htmlCanvas.Location = new Point(webBrowser1.Location.X, cssTB.Location.Y);
            _htmlCanvas.Size = webBrowser1.Size;
            _htmlCanvas.BackColor = Color.White;
            _htmlCanvas.Visible = true;
            Controls.Add(_htmlCanvas);

            htmlTB.Text = _defaultHTML;
            htmlTB.KeyDown += HtmlTBKeyDown;

            cssTB.Text = DefaultCSS.DefaultCSSString;

            webBrowser1.DocumentText = _defaultHTML;
            if (webBrowser1.Document != null)
                _doc = webBrowser1.Document.DomDocument as IHTMLDocument2;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (_doc != null)
            {
                _style = _doc.createStyleSheet("", 0);
                _style.cssText = cssTB.Text;
            }

            _htmlCanvas.HtmlText = htmlTB.Text;
        }

        private void HtmlTBKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
                ApplyButtonClick(sender, null);
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            if (htmlTB.Text == string.Empty)
                return;

            try
            {
                _htmlCanvas.HtmlText = htmlTB.Text;

                if (cssTB.Text != string.Empty)
                {
                    _style.cssText = cssTB.Text;
                    _doc.body.style.fontFamily = Font.Name;
                    _doc.body.style.fontSize = Font.Height;
                }

                _doc.body.innerHTML = htmlTB.Text;
                _htmlCanvas.CSSData = cssTB.Text;

                _htmlCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Wrong html");
            }
        }
    }
}
