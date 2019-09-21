using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class MaxpPool2d : Module
    {
        private int kernel_size;
        private int stride;
        private int padding;
        private int dilation;
        private bool return_indices;
        private bool ceil_mode;

        public int Kernel_size { get => kernel_size; set => kernel_size = value; }
        public int Stride { get => stride; set => stride = value; }
        public int Padding { get => padding; set => padding = value; }
        public int Dilation { get => dilation; set => dilation = value; }
        public bool Return_indices { get => return_indices; set => return_indices = value; }
        public bool Ceil_mode { get => ceil_mode; set => ceil_mode = value; }
    }
}
