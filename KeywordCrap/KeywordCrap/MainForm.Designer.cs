namespace KeywordCrap
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RightPanel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelWhite = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cmdLinkNegativeFiltering = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.cmdLinkPositiveFilter = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.panelnsight = new System.Windows.Forms.Panel();
            this.cmdLinkInsightGoAgain = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.cmdLinkInsightGo = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.label2 = new System.Windows.Forms.Label();
            this.InsightKW = new System.Windows.Forms.TextBox();
            this.panelKeywords = new System.Windows.Forms.Panel();
            this.cmdLinkGoAgain = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.cmdLinkGo = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.Keyword = new System.Windows.Forms.TextBox();
            this.clistPlugins = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBlack = new System.Windows.Forms.Panel();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.RightPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.PanelWhite.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelnsight.SuspendLayout();
            this.panelKeywords.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackgroundImage = global::KeywordCrap.Properties.Resources.back2;
            this.RightPanel.Controls.Add(this.statusStrip);
            this.RightPanel.Controls.Add(this.PanelWhite);
            this.RightPanel.Controls.Add(this.PanelBlack);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(212, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(869, 560);
            this.RightPanel.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(869, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 17);
            this.StatusLabel.Text = "Ready";
            // 
            // PanelWhite
            // 
            this.PanelWhite.BackColor = System.Drawing.Color.White;
            this.PanelWhite.Controls.Add(this.panelFilter);
            this.PanelWhite.Controls.Add(this.panelnsight);
            this.PanelWhite.Controls.Add(this.panelKeywords);
            this.PanelWhite.Location = new System.Drawing.Point(20, 17);
            this.PanelWhite.Name = "PanelWhite";
            this.PanelWhite.Size = new System.Drawing.Size(830, 497);
            this.PanelWhite.TabIndex = 4;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panelFilter.Controls.Add(this.cmdLinkNegativeFiltering);
            this.panelFilter.Controls.Add(this.cmdLinkPositiveFilter);
            this.panelFilter.Location = new System.Drawing.Point(222, 18);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(208, 459);
            this.panelFilter.TabIndex = 8;
            this.panelFilter.Tag = "SUBMENU";
            // 
            // cmdLinkNegativeFiltering
            // 
            this.cmdLinkNegativeFiltering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLinkNegativeFiltering.DescriptionText = "";
            this.cmdLinkNegativeFiltering.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLinkNegativeFiltering.HeaderText = "Negative Filtering";
            this.cmdLinkNegativeFiltering.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLinkNegativeFiltering.Image")));
            this.cmdLinkNegativeFiltering.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLinkNegativeFiltering.Location = new System.Drawing.Point(11, 47);
            this.cmdLinkNegativeFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLinkNegativeFiltering.Name = "cmdLinkNegativeFiltering";
            this.cmdLinkNegativeFiltering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLinkNegativeFiltering.Size = new System.Drawing.Size(181, 25);
            this.cmdLinkNegativeFiltering.TabIndex = 13;
            this.cmdLinkNegativeFiltering.Click += new System.EventHandler(this.cmdLinkNegativeFiltering_Click);
            // 
            // cmdLinkPositiveFilter
            // 
            this.cmdLinkPositiveFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLinkPositiveFilter.DescriptionText = "";
            this.cmdLinkPositiveFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLinkPositiveFilter.HeaderText = "Positive Filtering";
            this.cmdLinkPositiveFilter.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLinkPositiveFilter.Image")));
            this.cmdLinkPositiveFilter.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLinkPositiveFilter.Location = new System.Drawing.Point(11, 18);
            this.cmdLinkPositiveFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLinkPositiveFilter.Name = "cmdLinkPositiveFilter";
            this.cmdLinkPositiveFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLinkPositiveFilter.Size = new System.Drawing.Size(181, 25);
            this.cmdLinkPositiveFilter.TabIndex = 12;
            this.cmdLinkPositiveFilter.Click += new System.EventHandler(this.cmdLinkFilter_Click);
            // 
            // panelnsight
            // 
            this.panelnsight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panelnsight.Controls.Add(this.cmdLinkInsightGoAgain);
            this.panelnsight.Controls.Add(this.cmdLinkInsightGo);
            this.panelnsight.Controls.Add(this.label2);
            this.panelnsight.Controls.Add(this.InsightKW);
            this.panelnsight.Location = new System.Drawing.Point(8, 18);
            this.panelnsight.Name = "panelnsight";
            this.panelnsight.Size = new System.Drawing.Size(208, 340);
            this.panelnsight.TabIndex = 7;
            this.panelnsight.Tag = "SUBMENU";
            // 
            // cmdLinkInsightGoAgain
            // 
            this.cmdLinkInsightGoAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLinkInsightGoAgain.DescriptionText = "";
            this.cmdLinkInsightGoAgain.Enabled = false;
            this.cmdLinkInsightGoAgain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLinkInsightGoAgain.HeaderText = "Go Again";
            this.cmdLinkInsightGoAgain.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLinkInsightGoAgain.Image")));
            this.cmdLinkInsightGoAgain.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLinkInsightGoAgain.Location = new System.Drawing.Point(105, 231);
            this.cmdLinkInsightGoAgain.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLinkInsightGoAgain.Name = "cmdLinkInsightGoAgain";
            this.cmdLinkInsightGoAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLinkInsightGoAgain.Size = new System.Drawing.Size(97, 25);
            this.cmdLinkInsightGoAgain.TabIndex = 12;
            this.cmdLinkInsightGoAgain.Click += new System.EventHandler(this.cmdLinkInsightGoAgain_Click);
            // 
            // cmdLinkInsightGo
            // 
            this.cmdLinkInsightGo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLinkInsightGo.DescriptionText = "";
            this.cmdLinkInsightGo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLinkInsightGo.HeaderText = "Go";
            this.cmdLinkInsightGo.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLinkInsightGo.Image")));
            this.cmdLinkInsightGo.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLinkInsightGo.Location = new System.Drawing.Point(37, 231);
            this.cmdLinkInsightGo.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLinkInsightGo.Name = "cmdLinkInsightGo";
            this.cmdLinkInsightGo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLinkInsightGo.Size = new System.Drawing.Size(66, 25);
            this.cmdLinkInsightGo.TabIndex = 11;
            this.cmdLinkInsightGo.Click += new System.EventHandler(this.cmdLinkInsightGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keywords";
            // 
            // InsightKW
            // 
            this.InsightKW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsightKW.Location = new System.Drawing.Point(3, 22);
            this.InsightKW.Multiline = true;
            this.InsightKW.Name = "InsightKW";
            this.InsightKW.Size = new System.Drawing.Size(199, 204);
            this.InsightKW.TabIndex = 4;
            // 
            // panelKeywords
            // 
            this.panelKeywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panelKeywords.Controls.Add(this.chkReverse);
            this.panelKeywords.Controls.Add(this.cmdLinkGoAgain);
            this.panelKeywords.Controls.Add(this.cmdLinkGo);
            this.panelKeywords.Controls.Add(this.Keyword);
            this.panelKeywords.Controls.Add(this.clistPlugins);
            this.panelKeywords.Controls.Add(this.label1);
            this.panelKeywords.Location = new System.Drawing.Point(452, 24);
            this.panelKeywords.Name = "panelKeywords";
            this.panelKeywords.Size = new System.Drawing.Size(208, 321);
            this.panelKeywords.TabIndex = 2;
            this.panelKeywords.Tag = "SUBMENU";
            // 
            // cmdLinkGoAgain
            // 
            this.cmdLinkGoAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLinkGoAgain.DescriptionText = "";
            this.cmdLinkGoAgain.Enabled = false;
            this.cmdLinkGoAgain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLinkGoAgain.HeaderText = "Go Again";
            this.cmdLinkGoAgain.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLinkGoAgain.Image")));
            this.cmdLinkGoAgain.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLinkGoAgain.Location = new System.Drawing.Point(107, 265);
            this.cmdLinkGoAgain.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLinkGoAgain.Name = "cmdLinkGoAgain";
            this.cmdLinkGoAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLinkGoAgain.Size = new System.Drawing.Size(97, 25);
            this.cmdLinkGoAgain.TabIndex = 9;
            this.cmdLinkGoAgain.Click += new System.EventHandler(this.cmdLinkGoAgain_Click);
            // 
            // cmdLinkGo
            // 
            this.cmdLinkGo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLinkGo.DescriptionText = "";
            this.cmdLinkGo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLinkGo.HeaderText = "Go";
            this.cmdLinkGo.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLinkGo.Image")));
            this.cmdLinkGo.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLinkGo.Location = new System.Drawing.Point(37, 265);
            this.cmdLinkGo.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLinkGo.Name = "cmdLinkGo";
            this.cmdLinkGo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLinkGo.Size = new System.Drawing.Size(66, 25);
            this.cmdLinkGo.TabIndex = 8;
            this.cmdLinkGo.Click += new System.EventHandler(this.cmdLinkGo_Click);
            // 
            // Keyword
            // 
            this.Keyword.Location = new System.Drawing.Point(5, 216);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(199, 20);
            this.Keyword.TabIndex = 3;
            // 
            // clistPlugins
            // 
            this.clistPlugins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clistPlugins.FormattingEnabled = true;
            this.clistPlugins.Location = new System.Drawing.Point(4, 28);
            this.clistPlugins.Name = "clistPlugins";
            this.clistPlugins.Size = new System.Drawing.Size(200, 182);
            this.clistPlugins.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Plugin";
            // 
            // PanelBlack
            // 
            this.PanelBlack.BackColor = System.Drawing.Color.Black;
            this.PanelBlack.Location = new System.Drawing.Point(25, 22);
            this.PanelBlack.Name = "PanelBlack";
            this.PanelBlack.Size = new System.Drawing.Size(828, 496);
            this.PanelBlack.TabIndex = 3;
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Location = new System.Drawing.Point(6, 242);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(94, 17);
            this.chkReverse.TabIndex = 13;
            this.chkReverse.Text = "Reverse Seed";
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1081, 560);
            this.Controls.Add(this.RightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyword Crap";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.PanelWhite.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelnsight.ResumeLayout(false);
            this.panelnsight.PerformLayout();
            this.panelKeywords.ResumeLayout(false);
            this.panelKeywords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBlack;
        private System.Windows.Forms.Panel PanelWhite;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel panelKeywords;
        private System.Windows.Forms.Panel panelnsight;
        private System.Windows.Forms.Panel panelFilter;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLinkGo;
        private System.Windows.Forms.TextBox Keyword;
        private System.Windows.Forms.CheckedListBox clistPlugins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLinkGoAgain;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLinkInsightGoAgain;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLinkInsightGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsightKW;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLinkPositiveFilter;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLinkNegativeFiltering;
        private System.Windows.Forms.CheckBox chkReverse;



    }
}