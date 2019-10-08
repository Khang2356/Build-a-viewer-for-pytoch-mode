using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class Conv2d : Module
    {
        private int input_channel;
        private int output_channel;
        private int kernel_size;
        private int stride;
        private int padding;
        private int dilation;
        private int group;
        private bool bias = true;
        private string padding_mode;

        public int Input_channel { get => input_channel; set => input_channel = value; }
        public int Output_channel { get => output_channel; set => output_channel = value; }
        public int Kernel_size { get => kernel_size; set => kernel_size = value; }
        public int Stride { get => stride; set => stride = value; }
        public int Padding { get => padding; set => padding = value; }
        public int Dilation { get => dilation; set => dilation = value; }
        public int Group { get => group; set => group = value; }
        public bool Bias { get => bias; set => bias = value; }
        public string Padding_mode { get => padding_mode; set => padding_mode = value; }
    }
}
