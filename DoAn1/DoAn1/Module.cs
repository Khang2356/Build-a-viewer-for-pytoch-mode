using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public abstract class Module
    {
        public string name;
        public virtual void Input_layer() {
        }
        public virtual void Output_layer() {
        }

    }
}
