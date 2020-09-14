using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListExample
{
    public class EmptyListException : Exception
    {
        public EmptyListException(): base("The list is empty.")
        {
            
        }
    }
}
