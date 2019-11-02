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
        public int x;
        public int y;
        public int dai;
        public int rong;

        public int Kernel_size { get => kernel_size; set => kernel_size = value; }
        public int Stride { get => stride; set => stride = value; }
        public int Padding { get => padding; set => padding = value; }
        public bool Ceil_mode { get => ceil_mode; set => ceil_mode = value; }
        public bool Count_include_pad { get => count_include_pad; set => count_include_pad = value; }
        public int Divisor_override { get => divisor_override; set => divisor_override = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }

        public AvgPool2d(string name,List<Layer> inputs,List<Layer> outputs,int kernel_size,int stride,int padding,bool ceil_mode,bool count_include_pad,int divisor_override):base(name,inputs,outputs){
            this.kernel_size = kernel_size;
            this.stride = stride;
            this.padding = padding;
            this.ceil_mode = ceil_mode;
            this.count_include_pad = count_include_pad;
            this.divisor_override = divisor_override;
        }
    }
}
