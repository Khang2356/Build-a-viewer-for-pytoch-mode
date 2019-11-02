using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class Softmax : Module
    {
        private int dim;
        private int x;
        private int y;
        private int dai;
        private int rong;

        public int Dim { get => dim; set => dim = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }

        public Softmax(string name,List<Layer> inputs,List<Layer> outputs,int dim) : base(name, inputs, outputs) {
            this.dim = dim;
        }
    }
}
