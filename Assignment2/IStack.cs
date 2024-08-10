using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
    }

}
