using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pytorchmodel.Layers;
using Pytorchmodel.Layers.LinkedStructure;

namespace Pytorchmodel
{
    public class PytorchModel
    {
        public string ModelName;
        public List<Layer> Layers;

        public PytorchModel()
        {
            this.ModelName = "";
            this.Layers = new List<Layer>();
        }

        public PytorchModel(string name)
        {
            this.ModelName = name;
            this.Layers = new List<Layer>();
        }
    }
}
