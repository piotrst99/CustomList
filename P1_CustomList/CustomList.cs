using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_CustomList{
    public class CustomList<T>{
        private T[] _items = null;

        public CustomList() {
            _items = new T[0];
        }

        public CustomList(T[] items) {
            _items = new T[] { };
            foreach (T item in items) {
                _items.Append(item);
            }
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
                    result[i] = _items[i-1];
                }
            }
            _items = result;
        }

        public void ShowList() {
            if(_items.Length == 0) {
                Console.WriteLine("pusto");
                return;
            }
            foreach (T item in _items) {
                Console.WriteLine(item.ToString());
            }
        }

        public void ShowLength() {
            Console.WriteLine(_items.Length);
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
