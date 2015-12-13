using System;


namespace zad1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _size;
        private int _position;

        public IntegerList()
        {
            _internalStorage = new int[4];
            _size = 4;
            _position = 0;
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
            _size = initialSize;
            _position = 0;
        }

        public void Add(int item)
        {
            if (_position == _size)
            {
                int[] tempStorage = new int[_size];
                _internalStorage.CopyTo(tempStorage, 0);
                _size *= 2;
                _internalStorage = new int[_size];
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
                _internalStorage[index] = default(int);
            }
            _position--;
            return true;
        }

        public bool Remove(int item)
        {
            int index = _size;
            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    index = i;
                    break;
                }
            }
            return RemoveAt(index); 
        }

        public int GetElement(int index)
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

        public int IndexOf(int item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i] == item)
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
            _internalStorage = new int[_size];
            _position = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
