using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class MaxPool2d : Module
    {
        private int kernel_size;
        private int stride;
        private int padding;
        private int dilation;
        private bool return_indices;
        private bool ceil_mode;
        private int x;
        private int y;
        private int dai;
        private int rong;

        public int Kernel_size { get => kernel_size; set => kernel_size = value; }
        public int Stride { get => stride; set => stride = value; }
        public int Padding { get => padding; set => padding = value; }
        public int Dilation { get => dilation; set => dilation = value; }
        public bool Return_indices { get => return_indices; set => return_indices = value; }
        public bool Ceil_mode { get => ceil_mode; set => ceil_mode = value; }
<<<<<<< HEAD:DoAn1/DoAn1/MaxPool2d.cs
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }
=======

        public MaxpPool2d(string name,List<Layer> inputs,List<Layer> outputs,int kernel_size,int stride,int padding,int dilation,bool return_indices,bool ceil_mode):base(name, inputs, outputs) {
            this.kernel_size = kernel_size;
            this.stride = stride;
            this.padding = padding;
            this.dilation = dilation;
            this.return_indices = return_indices;
            this.ceil_mode = ceil_mode;
        }
>>>>>>> 8ddd08aa6a63729b60c54d2afbeae076d07606bf:DoAn1/DoAn1/MaxpPool2d.cs
    }
}
