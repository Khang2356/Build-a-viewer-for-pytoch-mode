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

        public int Input_channel { get => input_channel; set => input_channel = value; }
        public int Output_channel { get => output_channel; set => output_channel = value; }
        public int Kernel_size { get => kernel_size; set => kernel_size = value; }
        public int Stride { get => stride; set => stride = value; }
        public int Padding { get => padding; set => padding = value; }
    }
}
