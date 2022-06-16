using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory.Forms
{
    public partial class InGameSettingsForm : Form
    {
        Settings settings;

        private int numCols, numRows;
        private Timer afterClickTimer;
        private Timer timePassedTimer;

        private void afterClickBar_Scroll(object sender, EventArgs e)
        {
            settings.AfterClickMSec = afterClickBar.Value * 250;
            afterClickTimer.Interval = settings.AfterClickMSec;
        }

        private void InGameSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timePassedTimer.Start();
        }

        public InGameSettingsForm(int timePassed, int numPairsFound, int numMistakes, Timer timer, Timer timePassedTimer)
        {
            InitializeComponent();

            settings = Settings.GetInstance();
            this.afterClickTimer = timer;
            this.timePassedTimer = timePassedTimer;

            switch (settings.BoardSize)
            {
                case 1:
                    numCols = 8;
                    numRows = 6;
                    break;
                case 2:
                    numCols = 10;
                    numRows = 8;
                    break;
                case 3:
                    numCols = 12;
                    numRows = 10;
                    break;
            }

            timePassedLabel.Text = timePassed + "s";
            boardSizeLabel.Text = $"{numRows}, {numCols}";
            initMemoLabel.Text = settings.InitMemoSec.ToString() + "s";
            afterClickBar.Value = settings.AfterClickMSec / 250;
            pairsFoundLabel.Text = numPairsFound.ToString();
            numMistakesLabel.Text = numMistakes.ToString();
            
        }
    }
}
