using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace KeywordCrap.AppFrame
{
    public partial class IEGCheckBox : CheckBox
    {
        bool _IsChanged = false;
        RegistryKey _baseRegistryKey = Registry.CurrentUser;
        string _subKey = "";
        string _keyName="";
        string _checkedValue = "1";
        string _uncheckedValue = "0";

        public IEGCheckBox()
        {
            InitializeComponent();
        }

        public IEGCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool IsChanged
        {
            get
            {
                return _IsChanged;
            }
        }

        public void ResetChanges()
        {
            _IsChanged = false;
        }

        private void IEGCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _IsChanged = true;
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

        public string CheckedValue
        {
            get
            {
                return _checkedValue;
            }
            set
            {
                _checkedValue = value;
            }
        }

        public string UnCheckedValue
        {
            get
            {
                return _uncheckedValue;
            }
            set
            {
                _uncheckedValue = value;
            }
        }
    }
}
