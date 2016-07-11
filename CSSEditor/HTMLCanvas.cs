using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;
using TheArtOfDev.HtmlRenderer.Core;

namespace CSSEditor
{
    public partial class HTMLCanvas : UserControl
    {
        string _htmlText = string.Empty;
        string _cssData = DefaultCSS.DefaultCSSString;

        public HTMLCanvas()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        public string HtmlText
        {
            get { return _htmlText; }
            set
            {
                _htmlText = value;
                Refresh();
            }
        }

        public string CSSData
        {
            get { return _cssData; }
            set { _cssData = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            CssData cssData = HtmlRender.ParseStyleSheet(_cssData, false);

            HtmlContainer _container = new HtmlContainer();
            _container.MaxSize = Size;
            _container.Location = Point.Empty;
            _container.SetHtml(_htmlText, cssData);
            _container.PerformLayout(e.Graphics);
            _container.PerformPaint(e.Graphics);
        }
    }
}
