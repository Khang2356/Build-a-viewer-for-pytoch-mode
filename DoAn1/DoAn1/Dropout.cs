﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class Dropout: Module
    {
        private float p;
        private bool inplace;
        private int x;
        private int y;
        private int dai;
        private int rong;

        public float P { get => p; set => p = value; }
        public bool Inplace { get => inplace; set => inplace = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }
    }
}
