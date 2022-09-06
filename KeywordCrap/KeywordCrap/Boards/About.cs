using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using KeywordCrap.ClassLib;

namespace KeywordCrap.Boards
{
    public partial class About : BaseBoard
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GotoCompanyURL();
        }

        public void GotoCompanyURL()
        {
            FuncLib.OpenURL("http://www.devicode.com");
        }


        private void pictureLogo_Click(object sender, EventArgs e)
        {
            GotoCompanyURL();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            GotoCompanyURL();
        }
    }
}
