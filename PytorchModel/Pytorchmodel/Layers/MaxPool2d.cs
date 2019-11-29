using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pytorchmodel.Layers
{
    class MaxPool2d : Layer
    {
        public int kernel_size;
        public int strides;
        public int padding;
        public int dilation;
        bool return_indices;
        bool ceil_mode;

        public MaxPool2d()
        {
            this.Type = LayerTypes.MaxPool2d;
            this.kernel_size = -1;
            this.strides = -1;
            this.padding = -1;
            this.dilation = -1;
            this.return_indices = false;
            this.ceil_mode = false;
        }
        public MaxPool2d(string layername)
        {
            this.LayerName = layername;
            this.Type = LayerTypes.MaxPool2d;
            this.kernel_size = -1;
            this.strides = -1;
            this.padding = -1;
            this.dilation = -1;
            this.return_indices = false;
            this.ceil_mode = false;
        }

        public override void ReadAttribute(string _input)
        {
            try
            {
                int StartIndex;
                int EndIndex;
                // Doc kernel_size
                StartIndex = _input.IndexOf('(', 0);
                EndIndex = _input.IndexOf(',', 0); // Lay vi tri dau ',' dau tien trong chuoi 
                this.kernel_size = int.Parse(_input.Substring(0, EndIndex));

                // Doc strides
                StartIndex = EndIndex + 1;
                EndIndex = _input.IndexOf(',', StartIndex + 1); //Lay vi tri dau ',' thu 2
                this.strides = int.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));

                //doc padding
                StartIndex = _input.IndexOf("padding=") + 8;
                EndIndex = _input.IndexOf(',', StartIndex + 1);
                this.padding = int.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));


                //doc dilation
                StartIndex = _input.IndexOf("dilation=") + 9;
                EndIndex = _input.IndexOf(',', StartIndex + 1);
                this.dilation = int.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));

                // doc return_indices
                StartIndex = _input.IndexOf("return_indices=") + 15;
                EndIndex = _input.IndexOf(',', StartIndex + 1);
                this.return_indices = bool.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));

                // doc ceil_mode
                StartIndex = _input.IndexOf("ceil_mode=") + 10;
                EndIndex = _input.IndexOf(',', StartIndex + 1);
                this.ceil_mode = bool.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));

                // doc ten layer
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

            GraphicsNode.txtPropety_AddLine("kernel_size = " + kernel_size);
            GraphicsNode.txtPropety_AddLine("strides = " + strides);

            GraphicsNode.txtPropety_AddLine("padding = " + padding);
            GraphicsNode.txtPropety_AddLine("dilation = " + dilation);
        }
        public override List<string> ToString()
        {
            base.ToString();
            ReturnListToString.Add("\nAttributes");
            ReturnListToString.Add("     kernel_size: " + this.kernel_size.ToString());
            ReturnListToString.Add("     strides: " + this.strides.ToString());
            ReturnListToString.Add("     padding: " + this.padding.ToString());
            ReturnListToString.Add("     dilation: " + this.dilation.ToString());
            ReturnListToString.Add("     return_indices: " + this.return_indices.ToString());
            ReturnListToString.Add("     ceil_mode: " + this.ceil_mode.ToString());

            return ReturnListToString;
        }

    }

}
