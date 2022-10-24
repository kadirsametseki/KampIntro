using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>  //Generic class
    {
        T[] _array;
        T[] _tempArray;

        //Constructor
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get { return _array; }
        }

    }
}
