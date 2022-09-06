using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace KeywordCrap.AppFrame
{
    public partial class IEGTextbox : TextBox
    {
        bool _IsChanged = false;
        RegistryKey _baseRegistryKey = Registry.CurrentUser;
        string _subKey = "";
        string _keyName = "";

        public bool IsChanged {
            get
            {
                return _IsChanged;
            }
        }
        public IEGTextbox()
        {
            InitializeComponent();
        }

        public IEGTextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true),
   DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
   Bindable(true)]
        public RegistryKey BaseRegistryKey
        {
            get
            {
                return _baseRegistryKey;
            }
            set
            {
                _baseRegistryKey = value;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true),
           DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
           Bindable(true)]
        public string SubKey
        {
            get
            {
                return _subKey;
            }
            set
            {
                if (_subKey.StartsWith(@"\"))
                {
                    throw new Exception(@"Subkey cannot start with \");
                    _subKey = "";
                    return;
                }

                _subKey = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), 
           DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
           Bindable(true)]
        public string KeyName
        {
            get
            {
                return _keyName;
            }
            set
            {
                _keyName = value;
            }
        }



        public void ResetChanges()
        {
            _IsChanged = false;
        }
        private void IEGTextbox_TextChanged(object sender, EventArgs e)
        {
            _IsChanged = true;
        }
    }
}
