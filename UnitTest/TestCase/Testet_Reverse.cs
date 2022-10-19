using NUnit.Framework;
using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    
    public interface ITester_Reverse {
        void Compare_Reverse_IsCorrect();
        void Compare_Reverse_IsNotCorrect();
    }

    public class Tester_Reverse<T> : ITester_Reverse{
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }
        public T[] ExpectionResult { get; set; }

        public Tester_Reverse() {
            _customList = new CustomList<T>();
        }

        public void Compare_Reverse_IsCorrect() {
            _customList.Reverse();
            Assert.IsTrue(_customList == ExpectionResult);
        }

        public void Compare_Reverse_IsNotCorrect() {
            _customList.Reverse();
            Assert.IsFalse(_customList == ExpectionResult);
        }
    }
}
