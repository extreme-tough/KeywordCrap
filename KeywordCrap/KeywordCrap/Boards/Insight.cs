using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace KeywordCrap.Boards
{
    public partial class Insight : BaseBoard
    {
        DataTable dataStore = new DataTable();
        bool Ascending = false;


        public Insight()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
            InitDBStore();
        }

        public int GetResultCount()
        {
            return dataStore.Rows.Count;
        }
        private void InitDBStore()
        {
            dataStore.Columns.Add(new DataColumn("Keyword"));
            dataStore.Columns.Add(new DataColumn("Value"));
            dataStore.Columns.Add(new DataColumn("SortOrder",Type.GetType("System.Int32")));
            dataGridView.DataSource = dataStore;
            dataGridView.Columns[0].Width = (int)( dataGridView.Width * .50);
            dataGridView.Columns[1].Width = (int) (dataGridView.Width * .50);
            dataGridView.Columns[2].Visible = false;
        }

        public void Clear()
        {
            dataStore.Rows.Clear();
        }
        public void FetchAgain()
        {
            DataTable localDT = dataStore.Copy();
            foreach(DataRow dr in localDT.Rows)
            {
                FetchInsightData(dr["Keyword"].ToString());
            }
        }
        public void FetchInsightData(string ParaValue)
        {
            webBrowser.Navigate("about:blank");
            while (webBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            webBrowser.Navigate(@"http://www.google.com/insights/search/#q=" + ParaValue);
            while (true)
            {
                try
                {
                    if ((webBrowser.Document.Body.InnerText.Contains("Rising searches") ||
                        webBrowser.Document.Body.InnerText.Contains("Not enough search volume")) &&
                        webBrowser.Document.Body.InnerText.Contains("Insights for Search aims to provide insights")
                        )
                    {
                        break;
                    }
                }
                catch { }
                Application.DoEvents();
            }
            while (webBrowser.IsBusy)
            {
                Application.DoEvents();
            }
            while (webBrowser.ReadyState!=WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            while (webBrowser.IsBusy)
            {
                Application.DoEvents();
            }
            bool StartFetch=false;
            string test = "";
            try
            {
                foreach (HtmlElement oLink in webBrowser.Document.Links)
                {
                    if (oLink.OuterHtml.Contains("some of your selections may not apply"))
                        if (StartFetch)
                        {
                            StartFetch = false;
                            break;
                        }
                        else
                        {
                            StartFetch = true;
                            continue;
                        }
                    if (StartFetch)
                    {
                        //test += oLink.Parent.Parent.InnerHtml;
                        DataRow dr = dataStore.NewRow();
                        dr["Keyword"] = oLink.InnerText;
                        if (oLink.Parent.Parent.GetElementsByTagName("TD").Count > 2)
                            dr["Value"] = oLink.Parent.Parent.GetElementsByTagName("TD")[2].InnerText;
                        else
                            continue;
                        try
                        {
                            dr["SortOrder"] = int.Parse(dr["Value"].ToString().Trim().Replace("+", "").Replace("%", ""));
                        }
                        catch
                        {
                            dr["SortOrder"] = 0;
                        }
                        dataStore.Rows.Add(dr);
                    }
                }
            }
            catch { }
        }

        private void dataGridView_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SortedColumn.Name == "Value")
                    if (!Ascending)
                    {
                        dataGridView.Sort(dataGridView.Columns[2], ListSortDirection.Descending);
                        Ascending = true;
                    }
                    else
                    {
                        dataGridView.Sort(dataGridView.Columns[2], ListSortDirection.Ascending);
                        Ascending = false;
                    }
            }
            catch { }
        }
    }
}
