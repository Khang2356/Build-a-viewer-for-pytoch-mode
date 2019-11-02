using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class Dropout: Module
    {
        private float p;
        private bool inplace;
        private int x;
        private int y;
        private int dai;
        private int rong;

        public float P { get => p; set => p = value; }
        public bool Inplace { get => inplace; set => inplace = value; }
<<<<<<< HEAD
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }
=======

        public Dropout(string name,List<Layer> inputs,List<Layer> outputs,float p,bool inplace) : base(name, inputs, outputs) {
            this.p = p;
            this.inplace = inplace;
        }
>>>>>>> 8ddd08aa6a63729b60c54d2afbeae076d07606bf
    }
}
