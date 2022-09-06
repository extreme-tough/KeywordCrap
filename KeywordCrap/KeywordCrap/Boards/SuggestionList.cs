using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeywordCrap.Boards
{
    public partial class SuggestionList : BaseBoard
    {
        public SuggestionList()
        {
            InitializeComponent();
            InitBrowser();
        }

        public void ClearSuggestions()
        {
            txtSuggestions.Text = "";
        }
        public void FillSuggestions(HashSet<string> hSet)
        {
            string[] itemArray = new string[hSet.Count];
            hSet.CopyTo(itemArray);
            if (itemArray.Length > 0)
            txtSuggestions.Text= String.Join(Environment.NewLine, itemArray) + Environment.NewLine;
            
        }

        public void AppendSuggestions(HashSet<string> hSet)
        {
            string[] itemArray = new string[hSet.Count];
            hSet.CopyTo(itemArray);
            if (itemArray.Length>0)
            txtSuggestions.Text += String.Join(Environment.NewLine, itemArray) + Environment.NewLine;

        }


        private void InitBrowser()
        {
            webBrowser2.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(Application.StartupPath + @"\tdumForm.html");
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        private void cmdLinkTranslate_Click(object sender, EventArgs e)
        {
            string sURL;
            webBrowser2.Navigate(Application.StartupPath + @"\tdumForm.html");
            while (webBrowser2.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

            webBrowser2.Document.GetElementById("text").SetAttribute("value", txtSuggestions.Text);
            webBrowser2.Document.GetElementById("old_sl").SetAttribute("value",
                webBrowser1.Document.GetElementById("old_sl").GetAttribute("value"));
            webBrowser2.Document.GetElementById("old_tl").SetAttribute("value",
                webBrowser1.Document.GetElementById("old_tl").GetAttribute("value"));
            webBrowser2.Document.Forms[0].InvokeMember("submit");

            sURL = webBrowser2.Url.ToString();

            while (sURL == webBrowser2.Url.ToString())
            {
                Application.DoEvents();
            }
            while (webBrowser2.IsBusy)
            {
                Application.DoEvents();
            }
            while (webBrowser2.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            GetTranslatedText();
        }

        private void GetTranslatedText()
        {
            string sData;
            sData= webBrowser2.Document.GetElementById("result_box").InnerHtml;
            sData = sData.Replace("<BR>", Environment.NewLine);
            txTranslated.Text = sData;
        }
    }
}
