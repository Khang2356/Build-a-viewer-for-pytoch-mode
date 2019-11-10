using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    //Danh sách liên kết đơn lưu các layer 
    class SinglyLinkedList
    {
        public Node head, tail;
        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }
        public void AddFirst(string x)
        {

            Node temp = new Node();
            temp.data = x;
            if (head == null)
            {
                head = tail = temp;
                temp.next = null;
            }
            else
            {
                temp.next = head;
                head = temp;
            }

        }
        public void addLast(string x)
        {

            Node temp = new Node();
            temp.data = x;
            if (head == null)
            {
                head = tail = temp;
                temp.next = null;
            }
            else
            {
                tail.next = temp;
                temp.next = null;
                tail = temp;
            }
        }


    }


}
