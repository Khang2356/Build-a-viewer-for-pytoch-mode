﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class Linear : Module
    {
        private int input_features;
        private int output_features;
        private bool bias = true;
        private int x;
        private int y;
        private int dai;
        private int rong;

        public int Input_features { get => input_features; set => input_features = value; }
        public int Output_features { get => output_features; set => output_features = value; }
        public bool Bias { get => bias; set => bias = value; }
<<<<<<< HEAD
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }
=======

        public Linear(string name,List<Layer> inputs,List<Layer> outputs,int input_features,int output_features,bool bias) : base(name, inputs, outputs) {
            this.input_features = input_features;
            this.output_features = output_features;
            this.bias = bias;
        }
>>>>>>> 8ddd08aa6a63729b60c54d2afbeae076d07606bf
    }
}
