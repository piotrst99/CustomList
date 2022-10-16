using NUnit.Framework;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    
    public interface ITester_Remove {
        /*void Compare_Remove_IsCorrect();
        void Compare_Remove_IsNotCorrect();*/
        void GetCount_Remove_IsCorrect();
        void GetCount_Remove_IsNotCorrect();
        void GetCount_RemoveAt_IsCorrect();
        void GetCount_RemoveAt_IsNotCorrect();
    }

    public class Tester_Remove<T> : ITester_Remove {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }

        public T? Data { get; set; }
        public int Position { get; set; }
        public int ExpectionCountOfElement { get; set; }

        public Tester_Remove() {
            _customList = new CustomList<T>();
        }

        /*public void Compare_Remove_IsCorrect() {
            throw new NotImplementedException();
        }

        public void Compare_Remove_IsNotCorrect() {
            throw new NotImplementedException();
        }*/

        public void GetCount_Remove_IsCorrect() {
            _customList.RemoveElement(Data);
            Assert.AreEqual(_customList.Count, ExpectionCountOfElement);
        }

        public void GetCount_Remove_IsNotCorrect() {
            _customList.RemoveElement(Data);
            if (_customList.Count != 0) Assert.AreNotEqual(_customList.Count, 0);
            Assert.AreNotEqual(_customList.Count, _customList.Count + 1);
            Assert.AreNotEqual(_customList.Count, _customList.Count - 1);
        }

        public void GetCount_RemoveAt_IsCorrect() {
            _customList.RemoveAt(Position);
            Assert.AreEqual(_customList.Count, ExpectionCountOfElement);
        }

        public void GetCount_RemoveAt_IsNotCorrect() {
            _customList.RemoveAt(Position);
            if (_customList.Count != 0) Assert.AreNotEqual(_customList.Count, 0);
            Assert.AreNotEqual(_customList.Count, ExpectionCountOfElement + 1);
            Assert.AreNotEqual(_customList.Count, ExpectionCountOfElement - 1);
        }
    }
}
