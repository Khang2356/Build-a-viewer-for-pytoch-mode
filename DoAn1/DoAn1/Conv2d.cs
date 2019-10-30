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
        private int x;
        private int y;
        private int dai;
        private int rong;

        public int Input_channel { get => input_channel; set => input_channel = value; }
        public int Output_channel { get => output_channel; set => output_channel = value; }
        public int Kernel_size { get => kernel_size; set => kernel_size = value; }
        public int Stride { get => stride; set => stride = value; }
        public int Padding { get => padding; set => padding = value; }
        public int Dilation { get => dilation; set => dilation = value; }
        public int Group { get => group; set => group = value; }
        public bool Bias { get => bias; set => bias = value; }
        public string Padding_mode { get => padding_mode; set => padding_mode = value; }
<<<<<<< HEAD
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }
=======

        public Conv2d(string name,List<Layer> inputs,List<Layer> outputs,int input_channel,int output_channel,int kernel_size,int stride,int padding,int dilation,int group,bool bias,string padding_mode):base(name, inputs, outputs) {
            this.input_channel = input_channel;
            this.output_channel = output_channel;
            this.kernel_size = kernel_size;
            this.stride = stride;
            this.padding = padding;
            this.dilation = dilation;
            this.group = group;
            this.bias = bias;
            this.padding_mode = padding_mode;
        }
>>>>>>> 8ddd08aa6a63729b60c54d2afbeae076d07606bf
    }
}
