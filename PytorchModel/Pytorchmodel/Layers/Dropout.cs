using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pytorchmodel.Layers
{
    class Dropout : Layer
    {
        public float p;
        bool inplace;

        public Dropout()
        {
            this.Type = LayerTypes.Dropout;
            this.p = 0.0f;
            this.inplace = false;
        }

        public Dropout(string layername)
        {
            this.Type = LayerTypes.Dropout;
            this.LayerName = layername;
            this.p = 0.0f;
            this.inplace= false;
        }

        public override void ReadAttribute(string _input)
        {
            try
            {
                int StartIndex;
                int EndIndex;

                // Doc p
                StartIndex = _input.IndexOf("p=") + 2;
                EndIndex = _input.IndexOf(',', StartIndex + 1);
                this.p = float.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));
                // doc inplace

                StartIndex = _input.IndexOf("inplace=") + 8;
                EndIndex = _input.IndexOf(',', StartIndex + 1);
                this.inplace = bool.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));

                // Doc ten layer
                StartIndex = _input.IndexOf("name='") + 6;
                EndIndex = _input.LastIndexOf("'");
                this.LayerName = _input.Substring(StartIndex, EndIndex - StartIndex);
            }
            catch
            {

            }
        }

            public override void GraphicsNodeInitialize()
        {
            base.GraphicsNodeInitialize();
            this.GraphicsNode.NodeByType(Enum.GetName(typeof(LayerTypes), this.Type));
            GraphicsNode.txtPropety_AddLine("p = " + this.p);
            GraphicsNode.txtPropety_AddLine("inplace = " + this.inplace);
        }

        public override List<string> ToString()
        {
            base.ToString();
            ReturnListToString.Add("\nAttributes");
            ReturnListToString.Add("     p = " + this.p);
            ReturnListToString.Add("     inplace = " + this.inplace);
            return ReturnListToString;
        }

    }
}
