namespace CSSEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.htmlTB = new System.Windows.Forms.TextBox();
            this.cssTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(578, 287);
            this.webBrowser1.TabIndex = 0;
            // 
            // htmlTB
            // 
            this.htmlTB.Location = new System.Drawing.Point(584, 0);
            this.htmlTB.Multiline = true;
            this.htmlTB.Name = "htmlTB";
            this.htmlTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.htmlTB.Size = new System.Drawing.Size(405, 287);
            this.htmlTB.TabIndex = 1;
            // 
            // cssTB
            // 
            this.cssTB.Location = new System.Drawing.Point(584, 293);
            this.cssTB.Multiline = true;
            this.cssTB.Name = "cssTB";
            this.cssTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cssTB.Size = new System.Drawing.Size(405, 287);
            this.cssTB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cssTB);
            this.Controls.Add(this.htmlTB);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox htmlTB;
        private System.Windows.Forms.TextBox cssTB;
        private System.Windows.Forms.Button button1;
    }
}

