using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class SettingsForm : Form
    {
        Settings settings;

        private int numCols, numRows;

        public SettingsForm()
        {
            InitializeComponent();

            settings = Settings.GetInstance();

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

            boardSizeBar.Value = settings.BoardSize;
            boardSizeLabel.Text = $"{numRows}, {numCols}";

            initMemoBar.Value = settings.InitMemoSec / 10;
            initMemoLabel.Text = settings.InitMemoSec.ToString() + "s";

            afterClickBar.Value = settings.AfterClickMSec / 250;
            afterClickLabel.Text = (settings.AfterClickMSec / 1000).ToString() + "s";
        }

        private void boardSizeBar_Scroll(object sender, EventArgs e)
        {
            switch (boardSizeBar.Value)
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
                default:
                    numCols = 3;
                    numRows = 2;
                    break;
            }

            boardSizeLabel.Text = $"{numRows}, {numCols}";
            settings.BoardSize = boardSizeBar.Value;
        }

        private void initMemoBar_Scroll(object sender, EventArgs e)
        {
            initMemoLabel.Text = $"{initMemoBar.Value * 10}s";
            settings.InitMemoSec = initMemoBar.Value * 10;
        }

        private void afterClickBar_Scroll(object sender, EventArgs e)
        {
            afterClickLabel.Text = $"{afterClickBar.Value * 0.25}s";
            settings.AfterClickMSec = afterClickBar.Value * 250;
        }

    }
}
