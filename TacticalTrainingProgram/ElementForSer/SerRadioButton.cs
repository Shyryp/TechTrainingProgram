﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalTrainingProgram
{
    [Serializable]
    public class SerRadioButton
    {
        public int fontSize = 8;
        public int indexRadioB = 0;
        public int TrueOrFalse = 0;
        public string Text { get; set; } = "no_name";
        public string Name { get; set; } = "no_name";
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int SizeX { get; set; } = 0;
        public int SizeY { get; set; } = 0;
        public SerRadioButton() { }
        public SerRadioButton(string nameForm)
        { }
    }
}
