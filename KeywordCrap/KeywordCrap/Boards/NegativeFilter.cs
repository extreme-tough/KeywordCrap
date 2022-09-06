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
    public partial class NegativeFilter : BaseBoard
    {
        public int ResultCount;

        public event FilterEventHandler FilterCompleted;
        public delegate void FilterEventHandler(object sender, EventArgs e);

        public virtual void OnFilterComplete(object sender, EventArgs e)
        {
            if (FilterCompleted != null)
                FilterCompleted(sender, e);
        }


        public NegativeFilter()
        {
            InitializeComponent();
        }

        public void FillSuggestions(string sText)
        {
            txtOriginal.Text = sText;
        }


        private void FilterWords(string NegativeWords)
        {
            string FinalList="";
            bool AddThisWord = false;
            int i = 0;
            string[] words = txtOriginal.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] negativeList = NegativeWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);


            foreach (string word in words)
            {
                AddThisWord = true;
                if (NegativeWords.Trim() != "")
                    foreach (string negWord in negativeList)
                    {
                        if (word != "")
                            if (word.Contains(negWord))
                            {
                                AddThisWord = false;
                                break;
                            }
                    }
                if (AddThisWord && word != "")
                    FinalList += word + Environment.NewLine;
            }

            txtFiltered.Text = FinalList;
            ResultCount = FinalList.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length - 1;
        }

        private void cmdFilter_Click(object sender, EventArgs e)
        {
            FilterWords(txtFilter.Text);
            EventArgs ex = new EventArgs();
            this.OnFilterComplete(this, e);

        }

        private void cmdLink_Click(object sender, EventArgs e)
        {
            txtOriginal.Text = txtFiltered.Text;
        }

    }
}
