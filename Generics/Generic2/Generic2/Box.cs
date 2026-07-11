using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
    internal class Box<T>
    {

        //making a private field
        private T _data;

        public Box(T data)
        {
            _data = data;
        }

        public  T Display()
        {
            return _data;
        }
    }
}
