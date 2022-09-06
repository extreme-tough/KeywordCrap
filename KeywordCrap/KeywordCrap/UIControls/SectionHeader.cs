using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KeywordCrap.UIControls
{
    public partial class SectionHeader : UserControl
    {
        private string _Text="Title";

        public SectionHeader()
        {
            InitializeComponent();
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            groupBox.Width = width;
            base.SetBoundsCore(x, y, width, height, specified);
        }

        public int MyProperty { get; set; }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
            Bindable(true)]
        public override string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                label.Text = value;
            }
        }
    }
}
