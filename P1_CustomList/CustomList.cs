using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_CustomList{
    public class CustomList<T> {
        private T[] _items = null;

        public int Count {
            get {
                return _items.Length;
            }
        }

        public T this[int index] { 
            get{
                return _items[index];
            } 
            set{
                _items[index] = value;
            } 
        }

        public CustomList() {
            _items = new T[] { };
        }

        public CustomList(T[] items) {
            _items = new T[] { };
            foreach (T item in items) {
                _items.Append(item);
            }
        }

        public static bool operator ==(CustomList<T> t1, CustomList<T> t2) {
            if (t1.Count == t2.Count) {
                for (int i = 0; i < t1.Count; i++) {
                    if (t1[i].Equals(t2[i]))
                        continue;
                    else
                        return false;
                }
                return true;
            }
            return false;
        }

        public static bool operator !=(CustomList<T> t1, CustomList<T> t2) {
            if (t1.Count != t2.Count) {
                for (int i = 0; i < t1.Count; i++) {
                    if (t1[i].Equals(t2[i]))
                        continue;
                    else
                        return false;
                }
                return true;
            }
            return false;
        }

        public void Add(T item) {
            resizeArray(item);
        }

        public void AddRange(T[] items) {
            foreach (var item in items) {
                resizeArray(item);
            }
        }

        public void Insert(T item, int index) {
            T[] result = new T[_items.Length + 1];
            for (int i = 0; i < result.Length; i++) {
                if (i < index) {
                    result[i] = _items[i];
                }
                else if(i == index) {
                    result[i] = item;
                }
                else {
                    result[i] = _items[i - 1];
                }
            }
            _items = result;
        }

        public void Clear() {
            _items = new T[] { };
        }

        public void RemoveElement(T item) {
            bool isRemoved = false;
            T[] result = new T[_items.Length - 1];
            for (int i = 0; i < _items.Length; i++) {
                if (_items[i].Equals(item) && !isRemoved) {
                    isRemoved = true;
                }
                else {
                    if (isRemoved) {
                        result[i - 1] = _items[i];
                    }
                    else {
                        result[i] = _items[i];
                    }
                }
            }
            _items = result;
        }

        public void RemoveAt(int index) {
            bool isRemoved = false;
            T[] result = new T[_items.Length - 1];
            for (int i = 0; i < _items.Length; i++) {
                if (i == index && !isRemoved) {
                    isRemoved = true;
                }
                else {
                    if (isRemoved) {
                        result[i - 1] = _items[i];
                    }
                    else {
                        result[i] = _items[i];
                    }
                }
            }
            _items = result;
        }

        public void Reverse() {
            for (int i = 0; i < _items.Length / 2; i++) {
                T tmp = _items[i];
                _items[i] = _items[_items.Length - i - 1];
                _items[_items.Length - i - 1] = tmp;
            }
        }

        public bool Contains(T item) {
            foreach (T i in _items) {
                if (i.Equals(item))
                    return true;
            }
            return false;
        }

        private void resizeArray(T item) {
            T[] result = new T[_items.Length + 1];

            for (int i = 0; i < _items.Length; i++) {
                result[i] = _items[i];
            }

            result[_items.Length] = item;
            _items = result;
        }
    }
}
