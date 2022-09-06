using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using KeywordCrap.ClassLib;
using KeywordCrap.AppFrame;
using Microsoft.Win32;
using KeywordCrap.UIControls;

namespace KeywordCrap.Boards
{
    public partial class BaseBoard : UserControl
    {
        protected CRegistry WinRegistry = new CRegistry();

        public BaseBoard()
        {
            InitializeComponent();
            InitBalloonToolTip();
            WinRegistry.BaseRegistryKey = Registry.CurrentUser;
            //WinRegistry.ShowError = true;
        }

        private void InitBalloonToolTip()
        {
            ControlsInfo ctrlsInfo = new ControlsInfo();
            Hashtable htControlMsgs = ctrlsInfo.GetAllControlMessages();
        }


    }
}
