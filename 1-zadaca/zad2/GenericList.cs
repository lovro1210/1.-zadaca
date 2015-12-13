using System;


namespace zad2
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int _size;
        private int _position;

        public GenericList()
        {
            _internalStorage = new X[4];
            _size = 4;
            _position = 0;
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
            _size = initialSize;
            _position = 0;
        }

        public void Add(X item)
        {
            if (_position == _size)
            {
                X[] tempStorage = new X[_size];
                _internalStorage.CopyTo(tempStorage, 0);
                _size *= 2;
                _internalStorage = new X[_size];
                tempStorage.CopyTo(_internalStorage, 0);
            }
            _internalStorage[_position++] = item;
        }

        public bool RemoveAt(int index)
        {
            if (index >= _position)
            {
                return false;
            }
            if (index < _size - 1)
            {
                for (int i = index; i < _position; )
                {
                    _internalStorage[i++] = _internalStorage[i];
                }
            }
            else
            {
                _internalStorage[index] = default(X);
            }
            _position--;
            return true;
        }

        public bool Remove(X item)
        {
            int index = _size;
            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return RemoveAt(index);
        }

        public X GetElement(int index)
        {
            if (index < _size)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count
        {
            get
            {
                return _position;
            }
        }

        public void Clear()
        {
            _internalStorage = new X[_size];
            _position = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
