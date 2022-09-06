using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using Microsoft.VisualBasic;
using MT.WindowsUI.NavigationPane;
using KeywordCrap.Boards;
using KeywordCrap.AppFrame;
using KeywordCrap.ClassLib;
using ScriptPlug;

namespace KeywordCrap
{
    public partial class MainForm : Form
    {
        NavigateBar navigationPane;
        Panel[] SubMenuCollection  = new Panel[4];
        ScriptPlug.ScriptPlug oPlug = new ScriptPlug.ScriptPlug(); 
        HashSet<string> objHSet = new HashSet<string>();
        SuggestionList brdSugestions = new SuggestionList();
        Insight brdInsight = new Insight();
        PositiveFilter brdPosFilter = new PositiveFilter();
        NegativeFilter brdNegFilter = new NegativeFilter();
        
        public MainForm(string args)
        {
            InitializeComponent();
            
            navigationPane = new NavigateBar();
            navigationPane.IsCollapsible = false;
            navigationPane.Size = new Size(this.ClientSize.Width - RightPanel.Width, this.ClientSize.Height);
            navigationPane.Location = new Point(0, 0);
            navigationPane.NavigateBarButtons.Add(new NavigateBarButton("Keyword Suggestor", Appearance(),panelKeywords));
            navigationPane.NavigateBarButtons.Add(new NavigateBarButton("Google Insight", Advanced(), panelnsight));
            navigationPane.NavigateBarButtons.Add(new NavigateBarButton("Filter", IEOpt(),panelFilter));
            //navigationPane.NavigateBarDisplayedButtonCount = 2;
            navigationPane.NavigateBarColorTable = NavigateBarColorTable.Office2007Blue;

            brdPosFilter.FilterCompleted += new PositiveFilter.FilterEventHandler(this.Filter_Complete);
            brdNegFilter.FilterCompleted += new NegativeFilter.FilterEventHandler(this.FilterNeg_Complete);

            Controls.Add(navigationPane);

        }

        
        System.Drawing.Image IEOpt()
        {
            return System.Drawing.Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\The Internet.ico");
        }

        System.Drawing.Image Behave()
        {
            return System.Drawing.Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\61.ico");
        }

        System.Drawing.Image Appearance()
        {
            return System.Drawing.Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\ActiveX Cache.ico");
        }

        System.Drawing.Image Advanced()
        {
            return System.Drawing.Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\99.ico");
        }

        System.Drawing.Image Secure()
        {
            return System.Drawing.Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\4.ico");
        }

        System.Drawing.Image Tools()
        {
            return System.Drawing.Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\83.ico");
        }


#region Events
        private void MainForm_Load(object sender, EventArgs e)
        {            
            oPlug.PluginPath = Application.StartupPath + @"\plugins";            
            InitUI();
            FillPluginNames();
            
        }

#endregion

#region "User Methods"

        private void ShowBoard(UserControl UIBoard)
        {
            PanelWhite.Controls.Clear();
            PanelWhite.Controls.Add(UIBoard);
            UIBoard.Top = 0;
            UIBoard.Left = 0;
            UIBoard.Show();
        }

        private void InitUI()
        {
            ShowBoard(new About());
        }

#endregion


        private void FillPluginNames()
        {
            ArrayList objList ;
            objList = oPlug.GetPluginList();
            clistPlugins.Items.AddRange(objList.ToArray());
        }

        private HashSet<string> FetchSuggestions(string sKeyword,bool Reverse)
        {
            HashSet<string> retSet=new HashSet<string>();

            foreach (Object objItem in clistPlugins.CheckedItems)
            {
                string URL;
                string JSONData;
                string Suggestions;
                string[] SuggestionWords;
                string data;
                WebClient oClient = new WebClient();

                StatusLabel.Text = "Getting list for " + objItem.ToString() + "...";
                statusStrip.Refresh();

                URL = oPlug.GetURL(objItem.ToString(), sKeyword);
                try
                {
                    JSONData = oClient.DownloadString(URL);
                    Suggestions = oPlug.GetSuggestions(objItem.ToString(), JSONData);
                    SuggestionWords = Suggestions.Split(new char[] { ',' });
                    foreach (Object oitem in SuggestionWords)
                    {
                        try
                        {
                            //retSet.Add(oitem.ToString() + "(" + sKeyword);
                            data = oitem.ToString().Replace("\r", "").Replace("\n", "").Trim();
                            if (data != "")
                                retSet.Add(data);
                        }
                        catch { }
                    }

                    if (Reverse)
                    {
                        string ReversedStr;
                        ReversedStr = FuncLib.ReverseWords(sKeyword);
                        URL = oPlug.GetURL(objItem.ToString(), ReversedStr);
                        JSONData = oClient.DownloadString(URL);
                        Suggestions = oPlug.GetSuggestions(objItem.ToString(), JSONData);
                        SuggestionWords = Suggestions.Split(new char[] { ',' });
                        foreach (Object oitem in SuggestionWords)
                        {
                            try
                            {
                                data = oitem.ToString().Replace("\r", "").Replace("\n", "").Trim();
                                if (data != "")
                                    retSet.Add(data);
                            }
                            catch { }
                        }
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText("err.log", DateTime.Now.ToString() + ":" + ex.Message + ":cmdLinkGo_Click");
                }                
            }
            return retSet;
        }

        private void cmdLinkGo_Click(object sender, EventArgs e)
        {
            if (Keyword.Text == "")
            {
                MessageBox.Show("Keyword is empty. Please enter one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            objHSet = FetchSuggestions(Keyword.Text,chkReverse.Checked);

            
            ShowBoard(brdSugestions);
            brdSugestions.FillSuggestions(objHSet);
            StatusLabel.Text = "Fetched " + objHSet.Count.ToString() + " items";
            statusStrip.Refresh();

            if (objHSet.Count>0)
                cmdLinkGoAgain.Enabled = true;
            else
                cmdLinkGoAgain.Enabled = false;
            brdPosFilter.FillSuggestions(objHSet);
            
        }

        private void cmdLinkGoAgain_Click(object sender, EventArgs e)
        {
            HashSet<string> MergedSet = new HashSet<string>();
            string data;

            ShowBoard(brdSugestions);
            brdSugestions.ClearSuggestions();

            HashSet<string> localHSet;

            foreach (string sItem in objHSet)
            {
                if (sItem != "")
                    MergedSet.Add(sItem);
            }            

            foreach (string sItem in objHSet)
            {
                localHSet = FetchSuggestions(sItem, chkReverse.Checked);
                foreach (string sItemLocal in localHSet)
                {
                    data = sItemLocal.ToString().Replace("\r", "").Replace("\n", "").Trim();
                    if (data != "")
                        MergedSet.Add(data);
                }
                                
            }
            objHSet = MergedSet;
            brdSugestions.FillSuggestions(objHSet);

            StatusLabel.Text = "Fetched " + objHSet.Count.ToString() + " items";
            statusStrip.Refresh();
            brdPosFilter.FillSuggestions(objHSet);
        }

        private void cmdLinkInsightGo_Click(object sender, EventArgs e)
        {
            string ParaValue="";
            string[] KeyList = InsightKW.Text.Split(new string[] { Environment.NewLine},StringSplitOptions.None);
            ParaValue=string.Join("%2C", KeyList);
            ParaValue = ParaValue.Replace(" ", "%20");

            ShowBoard(brdInsight);
            StatusLabel.Text = "Performaing insight search. Please wait";
            statusStrip.Refresh();
            brdInsight.Clear();
            brdInsight.FetchInsightData(ParaValue);
            StatusLabel.Text = "Fetched " + brdInsight.GetResultCount().ToString() + " items";
            statusStrip.Refresh();
            if (brdInsight.GetResultCount()>0)
            {
                cmdLinkInsightGoAgain.Enabled=true;
            }
        }

        private void cmdLinkInsightGoAgain_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Performaing further search. Please wait";
            statusStrip.Refresh();
            brdInsight.FetchAgain();
            StatusLabel.Text = "Fetched " + brdInsight.GetResultCount().ToString() + " items";
            statusStrip.Refresh();
        }

        private void cmdLinkFilter_Click(object sender, EventArgs e)
        {
            ShowBoard(brdPosFilter);
        }

        private void Filter_Complete(object sender, EventArgs e)
        {            
            StatusLabel.Text = "Filtered to " + brdPosFilter.ResultCount.ToString() + " items";
            brdNegFilter.FillSuggestions(brdPosFilter.GetFilteredText());
            statusStrip.Refresh();

        }

        private void FilterNeg_Complete(object sender, EventArgs e)
        {
            StatusLabel.Text = "Filtered to " + brdNegFilter.ResultCount.ToString() + " items";
            statusStrip.Refresh();
        }

        private void cmdLinkNegativeFiltering_Click(object sender, EventArgs e)
        {
            ShowBoard(brdNegFilter);
        }
 
    }
}