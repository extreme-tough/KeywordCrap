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
    public partial class PositiveFilter : BaseBoard
    {
        public int ResultCount;

        public event FilterEventHandler FilterCompleted;
        public delegate void FilterEventHandler(object sender, EventArgs e);

        public virtual void OnFilterComplete(object sender, EventArgs e)
        {
            if (FilterCompleted != null)
                FilterCompleted(sender, e);
        }


        public PositiveFilter()
        {
            InitializeComponent();
        }

        public void FillSuggestions(HashSet<string> hSet)
        {
            string[] itemArray = new string[hSet.Count];
            hSet.CopyTo(itemArray);
            txtOriginal.Text = String.Join(Environment.NewLine, itemArray);
        }

        public string GetFilteredText()
        {
            return txtFiltered.Text;
        }

        private void FilterWords(string PositiveWords)
        {
            string TempList="";
            bool AddThisWord=false;
            int i = 0;
            string[] words = txtOriginal.Text.Split(new string[]{Environment.NewLine},StringSplitOptions.None);
            string[] positiveList = PositiveWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string word in words)
            {
                AddThisWord=false;
                if (PositiveWords.Trim() != "")
                    foreach (string posWord in positiveList)
                    {
                        if (word != "")
                            if (word.Contains(posWord))
                            {
                                AddThisWord = true;
                                break;
                            }
                    }
                else
                    AddThisWord = true;
                if (AddThisWord && word!="")
                    TempList += word + Environment.NewLine;
            }

            //words = TempList.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            //foreach (string word in words)
            //{
            //    AddThisWord = true;
            //    if (NegativeWords.Trim() != "")
            //        foreach (string negWord in negativeList)
            //        {
            //            if (word!="")
            //                if (word.Contains(negWord))
            //                {
            //                    AddThisWord = false;
            //                    break;
            //                }
            //        }
            //    if (AddThisWord && word != "")
            //        FinalList += word + Environment.NewLine;
            //}

            txtFiltered.Text = TempList;
            ResultCount = TempList.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length - 1;
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
