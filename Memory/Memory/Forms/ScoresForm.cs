using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Memory
{
       public partial class ScoresForm : Form
    {
        public ScoresForm(List<HighScore> highScores)
        {
            InitializeComponent();

            scoresList.View = View.Details;
            scoresList.Columns.Add("Score");
            scoresList.Columns.Add("Name");
            scoresList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            scoresList.GridLines = true;

            foreach (var s in highScores)
            {
                scoresList.Items.Add(new ListViewItem(new string[] { s.Score.ToString(), s.Name }));
            }
        }
    }
}
