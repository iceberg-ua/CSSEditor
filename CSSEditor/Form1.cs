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

        string _defaultHTML = "<body><h1>Title</h1></body>";
        string _defaultCSS = "h1 { background-color: yellow; }";

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
            cssTB.Text = _defaultCSS;

            htmlTB.KeyDown += HtmlTBKeyDown;
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
                webBrowser1.DocumentText = htmlTB.Text;

                if (cssTB.Text != string.Empty)
                {
                    _style.cssText = cssTB.Text;
                    _doc.clear();
                }
            }
            catch
            {
                MessageBox.Show("Wrong html");
            }
        }
    }
}
