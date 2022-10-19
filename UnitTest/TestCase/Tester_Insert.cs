using NUnit.Framework;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_Insert {
        void Compare_Insert_IsCorrect();
        void Compare_Insert_IsNotCorrect();
    }

    public class Tester_Insert<T> : ITester_Insert {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }
        public T Data { get; set; }
        public int Position { get; set; }
        public T ExpectedResult { get; set; }

        public Tester_Insert() {
            _customList = new CustomList<T>();
        }

        public void Compare_Insert_IsCorrect() {
            _customList.Insert(Data, Position);
            Assert.IsTrue(_customList[Position].Equals(Data));
        }

        public void Compare_Insert_IsNotCorrect() {
            _customList.Insert(Data, Position);
            Assert.IsFalse(_customList[Position].Equals(ExpectedResult));
        }
    }
}
