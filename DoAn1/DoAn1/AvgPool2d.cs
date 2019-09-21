using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class AvgPool2d : Module
    {
        private int kernel_size;
        private int stride;
        private int padding;
        private bool ceil_mode;
        private bool count_include_pad;
        private int divisor_override;

        public int Kernel_size { get => kernel_size; set => kernel_size = value; }
        public int Stride { get => stride; set => stride = value; }
        public int Padding { get => padding; set => padding = value; }
        public bool Ceil_mode { get => ceil_mode; set => ceil_mode = value; }
        public bool Count_include_pad { get => count_include_pad; set => count_include_pad = value; }
        public int Divisor_override { get => divisor_override; set => divisor_override = value; }
    }
}
