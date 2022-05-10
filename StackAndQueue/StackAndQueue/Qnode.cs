using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QNode<M>
    {
        public M key;
        public QNode<M> next;

        public QNode (M Key)
        {
            this.key = Key;
            this.next = null;
        }
    }
}





