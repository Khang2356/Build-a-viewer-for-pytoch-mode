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

        public int Dim { get => dim; set => dim = value; }

        public Softmax(string name,List<Layer> inputs,List<Layer> outputs,int dim) : base(name, inputs, outputs) {
            this.dim = dim;
        }

    }
}
