using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Node<M>
    {
        public M data;

        public Node<M> link;
        public Node(M Key)
        {
            this.data = Key;
            this.link = null;
        }


    }
}
