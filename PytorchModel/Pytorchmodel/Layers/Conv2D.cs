using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pytorchmodel.Layers
{
    class Conv2d : Layer
    {
        public int in_channels;
        public int out_channels;
        public int kernel_size;
        public int stride;
        public int padding;

        public Conv2d()
        {
            this.Type = LayerTypes.Conv2d;
            this.in_channels = -1;
            this.out_channels = -1;
            this.kernel_size = -1;
            this.stride = -1;
            this.padding = -1;

        }

        public Conv2d(string layername)
        {
            this.LayerName = layername;
            this.Type = LayerTypes.Conv2d;
            this.in_channels = -1;
            this.out_channels = -1;
            this.kernel_size = -1;
            this.stride = -1;
            this.padding = -1;
        }

        public override void ReadAttribute(string _input)
        {
            try
            {
                int StartIndex;
                int EndIndex;
                // Doc in_channels
                StartIndex = _input.IndexOf('(', 0);
                EndIndex = _input.IndexOf(',', 0); // Lay vi tri dau ',' dau tien trong chuoi 
                this.in_channels = int.Parse(_input.Substring(0, EndIndex));

                // Doc out_channels
                StartIndex = EndIndex + 1;
                EndIndex = _input.IndexOf(',', StartIndex +1); //Lay vi tri dau ',' thu 2
                this.out_channels = int.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));

                // Doc kernel_size
                StartIndex = _input.IndexOf("kernel_size=") + 12; 
                EndIndex = _input.IndexOf(',', StartIndex +1); 
                this.kernel_size = int.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));



                // Doc stride

                StartIndex = _input.IndexOf("stride=") + 7;
                EndIndex = _input.IndexOf(',', StartIndex +1);
                this.stride = int.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));


                // Doc padding
                StartIndex = _input.IndexOf("padding=") + 8;
                EndIndex = _input.LastIndexOf(',', StartIndex +1);
                this.padding = int.Parse(_input.Substring(StartIndex, EndIndex - StartIndex));


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
            GraphicsNode.txtPropety_AddLine("in_channels = " + in_channels);

            GraphicsNode.txtPropety_AddLine("out_channels = " + out_channels);


            GraphicsNode.txtPropety_AddLine("kernel_size = " + kernel_size);

            
        }

        public override List<string> ToString()
        {
            base.ToString();
            ReturnListToString.Add("\nAttributes");
            ReturnListToString.Add("     in_channels: " + this.in_channels.ToString());
            ReturnListToString.Add("     out_channels: " + this.out_channels.ToString());
            ReturnListToString.Add("     kernel_size: " + this.kernel_size.ToString());
            ReturnListToString.Add("     stride: " + this.stride.ToString());
            ReturnListToString.Add("     padding: " + this.padding.ToString());

            return ReturnListToString;
        }

    }
}
