using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public sealed class Settings
    {
        private Settings() { }
        private static Settings _instance;
        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }

        private int boardSize = 1;
        private int initMemoSec = 20;
        private int afterClickMSec = 1000;
        private bool computerChooses = false;

        public int BoardSize { get => boardSize; set => boardSize = value; }
        public int InitMemoSec { get => initMemoSec; set => initMemoSec = value; }
        public int AfterClickMSec { get => afterClickMSec; set => afterClickMSec = value; }
        public bool ComputerChooses { get => computerChooses; set => computerChooses = value; }
    }
}
