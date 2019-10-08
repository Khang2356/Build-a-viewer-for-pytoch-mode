using System;
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

        public int Input_features { get => input_features; set => input_features = value; }
        public int Output_features { get => output_features; set => output_features = value; }
        public bool Bias { get => bias; set => bias = value; }
    }
}
