using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public abstract class Layer
    {
        //name
        //inputs
        //outputs
        public string name;
        List<Layer> inputs = new List<Layer>();
        List<Layer> outputs = new List<Layer>();
    }
    public  class Module
    {
        private string name;
        private List<Layer> inputs;
        private List<Layer> outputs;

        public Module()
        { }
        public Module(string name, List<Layer> inputs, List<Layer> outputs)
        {
            this.name = name;
            this.inputs = inputs;
            this.outputs = outputs;
        }

        //cau truc luu so do Layer
        class Node
        {
            protected Layer Data;
            protected Node Next;
            public Node(Layer x, Node next)
            {
                Data = x;
                this.Next = next;
            }
            public Layer data
            {
                get { return Data; }
                set { Data = value; }
            }
            public Node next
            {
                get { return Next; }
                set { Next = value; }
            }
        }
        class SingleLinkList
        {
            protected Node head; // Vi trí đầu
            protected Node next;  // vị trí cuối

            // Khởi tạo 1 danh sách LK đơn rỗng
            public SingleLinkList()
            {
            head = next = null;
            }
            public void AddHead(Layer x)
            {
                Node Data = new Node(x, head);
                head = Data;
            }
            public void AddTail(Layer x)
            {
                Node Dropout = new Node(x, next);
                next = Dropout;
                Node Conv2d = new Node(x, next);
                next = Conv2d;
                Node Linear = new Node(x, next);
                next = Linear;
                Node BatchNorm2d = new Node(x, next);
                next = BatchNorm2d;
                Node MaxPool2d = new Node(x, next);
                next = MaxPool2d;
                Node AvgPool2d = new Node(x, next);
                next = AvgPool2d;
                Node Softmax = new Node(x, next);
                next = Softmax;
            }
        }
        
    }
}
