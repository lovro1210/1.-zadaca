using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad4
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        IGenericList<T> _collection;
        int position;

        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
            position = -1;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _collection.Count);
        }

        public T Current
        {
            get
            {
                return _collection.GetElement(position);
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            // Ignorirajte
        }

        public void Reset()
        {
            // Ignorirajte
        }
    }
}
