namespace KeywordCrap.Boards
{
    partial class PositiveFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositiveFilter));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltered = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdFilter = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.cmdLink = new KeywordCrap.AppFrame.IEGMenuCommandLink();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filtered List";
            // 
            // txtFiltered
            // 
            this.txtFiltered.Location = new System.Drawing.Point(531, 18);
            this.txtFiltered.Multiline = true;
            this.txtFiltered.Name = "txtFiltered";
            this.txtFiltered.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFiltered.Size = new System.Drawing.Size(285, 440);
            this.txtFiltered.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Original List";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(6, 18);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(251, 440);
            this.txtOriginal.TabIndex = 15;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(263, 18);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilter.Size = new System.Drawing.Size(262, 440);
            this.txtFilter.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filter Words";
            // 
            // cmdFilter
            // 
            this.cmdFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdFilter.DescriptionText = "";
            this.cmdFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFilter.HeaderText = "Go";
            this.cmdFilter.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdFilter.Image")));
            this.cmdFilter.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdFilter.Location = new System.Drawing.Point(635, 463);
            this.cmdFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFilter.Name = "cmdFilter";
            this.cmdFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdFilter.Size = new System.Drawing.Size(181, 25);
            this.cmdFilter.TabIndex = 21;
            this.cmdFilter.Click += new System.EventHandler(this.cmdFilter_Click);
            // 
            // cmdLink
            // 
            this.cmdLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLink.DescriptionText = "";
            this.cmdLink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLink.HeaderText = "Copy to Original";
            this.cmdLink.Image = ((System.Drawing.Bitmap)(resources.GetObject("cmdLink.Image")));
            this.cmdLink.ImageScalingSize = new System.Drawing.Size(12, 13);
            this.cmdLink.Location = new System.Drawing.Point(478, 463);
            this.cmdLink.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLink.Name = "cmdLink";
            this.cmdLink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLink.Size = new System.Drawing.Size(130, 25);
            this.cmdLink.TabIndex = 30;
            this.cmdLink.Click += new System.EventHandler(this.cmdLink_Click);
            // 
            // PositiveFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdLink);
            this.Controls.Add(this.cmdFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltered);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOriginal);
            this.Name = "PositiveFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdFilter;
        private KeywordCrap.AppFrame.IEGMenuCommandLink cmdLink;
    }
}
