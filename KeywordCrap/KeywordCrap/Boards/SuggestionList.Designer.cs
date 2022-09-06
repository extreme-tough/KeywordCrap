namespace KeywordCrap.Boards
{
    partial class SuggestionList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuggestionList));
            this.txtSuggestions = new System.Windows.Forms.TextBox();
            this.cmdLinkTranslate = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txTranslated = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSuggestions
            // 
            this.txtSuggestions.Location = new System.Drawing.Point(7, 24);
            this.txtSuggestions.Multiline = true;
            this.txtSuggestions.Name = "txtSuggestions";
            this.txtSuggestions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSuggestions.Size = new System.Drawing.Size(404, 431);
            this.txtSuggestions.TabIndex = 1;
            // 
            // cmdLinkTranslate
            // 
            this.cmdLinkTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLinkTranslate.DescriptionText = "";
            this.cmdLinkTranslate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLinkTranslate.HeaderText = "Translate";
            this.cmdLinkTranslate.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLinkTranslate.Image")));
            this.cmdLinkTranslate.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLinkTranslate.Location = new System.Drawing.Point(349, 460);
            this.cmdLinkTranslate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLinkTranslate.Name = "cmdLinkTranslate";
            this.cmdLinkTranslate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLinkTranslate.Size = new System.Drawing.Size(94, 25);
            this.cmdLinkTranslate.TabIndex = 9;
            this.cmdLinkTranslate.Click += new System.EventHandler(this.cmdLinkTranslate_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(7, 447);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(337, 35);
            this.webBrowser1.TabIndex = 10;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(160, 177);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(445, 243);
            this.webBrowser2.TabIndex = 11;
            this.webBrowser2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Suggestion List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Translated Words";
            // 
            // txTranslated
            // 
            this.txTranslated.Location = new System.Drawing.Point(417, 24);
            this.txTranslated.Multiline = true;
            this.txTranslated.Name = "txTranslated";
            this.txTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txTranslated.Size = new System.Drawing.Size(398, 429);
            this.txTranslated.TabIndex = 13;
            // 
            // SuggestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txTranslated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.cmdLinkTranslate);
            this.Controls.Add(this.txtSuggestions);
            this.Controls.Add(this.webBrowser1);
            this.Name = "SuggestionList";
            this.Size = new System.Drawing.Size(830, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSuggestions;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLinkTranslate;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTranslated;
    }
}
