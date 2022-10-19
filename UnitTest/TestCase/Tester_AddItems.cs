using Microsoft.VisualStudio.TestTools.UnitTesting;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_AddItems {
        void GetCount_AddItems_IsCorrect();
        void GetCount_AddItems_IsNotCorrect();
    }

    public class Tester_AddItems<T> : ITester_AddItems {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }
        public T[] Datas { get; set; }
        public int ExpectedResult { get; set; }

        public Tester_AddItems() {
            _customList = new CustomList<T>();
        }

        public void GetCount_AddItems_IsCorrect() {
            _customList.AddRange(Datas);
            Assert.AreEqual(_customList.Count, ExpectedResult);
        }

        public void GetCount_AddItems_IsNotCorrect() {
            _customList.AddRange(Datas);
            if (_customList.Count != 0) Assert.AreNotEqual(_customList.Count, 0);
            Assert.AreNotEqual(_customList.Count, ExpectedResult - 1);
            Assert.AreNotEqual(_customList.Count, ExpectedResult - 1);
        }
    }
}
