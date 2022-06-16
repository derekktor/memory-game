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
using Memory.Forms;

namespace Memory
{
    public partial class GameForm : Form
    {
        private readonly Timer initMemoTimer = new Timer();
        private readonly Timer afterClickTimer = new Timer();
        private readonly Timer timePassedTimer = new Timer();

        private Cell[] lastClick;
        private bool isClickable = false;

        private Settings settings;

        private int timePassed = 0;
        private int numMistakes = 0;

        private string name;
        private int numPairsFound = 0;

        private List<HighScore> highScores;

        private Random random;

        public GameForm(string name, List<HighScore> highScores)
        {
            InitializeComponent();
            this.name = name;
            this.highScores = highScores;
            settings = Settings.GetInstance();
            lastClick = new Cell[2];

            CreateBoard();

            board.SuspendLayout();

            InitializeCells();

            board.ResumeLayout();

            InitializeTimers();
        }

        private void InitializeTimers()
        {
            initMemoTimer.Tick += InitMemoTimer_Tick;
            afterClickTimer.Tick += AfterClickTimer_Tick;
            timePassedTimer.Tick += TimePassedTimer_Tick;

            initMemoTimer.Interval = settings.InitMemoSec * 1000;
            afterClickTimer.Interval = settings.AfterClickMSec;
            timePassedTimer.Interval = 1000;

            initMemoTimer.Start();
            timePassedTimer.Start();
        }

        private void InitializeCells()
        {
            int numCells = board.RowCount * board.ColumnCount;
            List<int> indices = Enumerable.Range(0, numCells).ToList();
            random = new Random();

            for (int i = 0; indices.Count != 0; i++)
            {
                Cell cell = new Cell
                {
                    ImgID = (i + 1) % 2 == 0 ? i / 2 : (i + 1) / 2
                };
                cell.Click += cell_Click;
                int r = random.Next(indices.Count);
                int index = indices[r];
                indices.RemoveAt(r);
                board.Controls.Add(cell, index % board.ColumnCount, index / board.ColumnCount);
            }
        }

        private void CreateBoard()
        {
            switch (settings.BoardSize)
            {
                case 1:
                    board.ColumnCount = 8;
                    board.RowCount = 6;
                    break;
                case 2:
                    board.ColumnCount = 10;
                    board.RowCount = 8;
                    break;
                case 3:
                    board.ColumnCount = 12;
                    board.RowCount = 10;
                    break;
                default:
                    board.ColumnCount = 3;
                    board.RowCount = 2;
                    break;
            }

            board.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            board.RowStyles.Clear();
            board.ColumnStyles.Clear();

            for (int i = 0; i < board.RowCount; i++)
            {
                board.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / board.RowCount));
            }
            for (int i = 0; i < board.ColumnCount; i++)
            {
                board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / board.ColumnCount));
            }
        }


        private void cell_Click(object sender, EventArgs e)
        {
            if (!isClickable || sender==lastClick[0]) return;

            lastClick[1] = (Cell)sender;
            lastClick[1].Image = lastClick[1].Img;
            if (lastClick[0] == null) lastClick[0] = lastClick[1];
            else
            {
                if(lastClick[0].ImgID != lastClick[1].ImgID)
                {
                    isClickable = false;
                    numMistakes++;
                    numMistakesLabel.Text = numMistakes.ToString();
                    afterClickTimer.Start();
                }
                else
                {
                    for (int i = 0; i < lastClick.Length; i++)
                    {
                        board.Controls.Remove(lastClick[i]);
                        lastClick[i].Dispose();
                        lastClick[i] = null;
                        numPairsFound++;
                        if (board.RowCount * board.ColumnCount == numPairsFound) gameOver();
                    }
                }
            }
        }

        private void InitMemoTimer_Tick(object myObject, EventArgs myEventArgs)
        {
            initMemoTimer.Stop();
            foreach (var control in board.Controls)
            {
                var c = (Cell)control;
                c.Image = null;
            }
            isClickable = true;
        }

        private void AfterClickTimer_Tick(object myObject, EventArgs myEventArgs)
        {
            afterClickTimer.Stop();
            for (int i = 0; i < lastClick.Length; i++)
            {
                lastClick[i].Image = null;
                lastClick[i] = null;
            }
            isClickable = true;
        }

        private void TimePassedTimer_Tick(object myObject, EventArgs myEventArgs)
        {
            timePassed++;
            timePassedLabel.Text = $"{timePassed / 60}m {timePassed % 60}s";
        }


        private void gameOver()
        {
            var serializer = new XmlSerializer(highScores.GetType(), "HighScores.Scores");

            int boardDifficulty = board.RowCount * board.ColumnCount;
            double num = boardDifficulty * boardDifficulty;
            double den = timePassed * (numMistakes + 1);

            var score = new HighScore()
            {
                Score = (int)(num / den * 100),
                Name = name 
            };

            var index = highScores.BinarySearch(score);
            if (index < 0) index = ~index;
            highScores.Insert(index, score);

            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, highScores);
            }

            MessageBox.Show($"{boardDifficulty}\n{timePassed}\n{numMistakes}\n{score}");

            ScoresForm scores = new ScoresForm(highScores);
            scores.ShowDialog();
            this.Close();
        }

        private void InGameSettingsBtn_Click(object sender, EventArgs e)
        {
            timePassedTimer.Stop();
            Forms.InGameSettingsForm igSettingsForm = new InGameSettingsForm(timePassed, numPairsFound, numMistakes, afterClickTimer, timePassedTimer);
            igSettingsForm.ShowDialog();
        }
    }
}
