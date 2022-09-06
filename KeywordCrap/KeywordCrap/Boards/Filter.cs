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
    public partial class Filter : BaseBoard
    {
        public Filter()
        {
            InitializeComponent();
        }

        public void FillSuggestions(HashSet<string> hSet)
        {
            string[] itemArray = new string[hSet.Count];
            hSet.CopyTo(itemArray);
            txtOriginal.Text = String.Join(Environment.NewLine, itemArray);
        }

        public int FilterWords(string PositiveWords, string NegativeWords)
        {
            string TempList="",FinalList="";
            bool AddThisWord=false;
            int i = 0;
            string[] words = txtOriginal.Text.Split(new string[]{Environment.NewLine},StringSplitOptions.None);
            string[] positiveList = PositiveWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] negativeList = NegativeWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
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

            words = TempList.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string word in words)
            {
                AddThisWord = true;
                if (NegativeWords.Trim() != "")
                    foreach (string negWord in negativeList)
                    {
                        if (word!="")
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
            return FinalList.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length-1;
        }


    }
}
