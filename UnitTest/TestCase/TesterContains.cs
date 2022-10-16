using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_Contains{

    }

    public class Tester_Contains<T> : ITester_Contains {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }

        public Tester_Contains() {
            _customList = new CustomList<T>();
        }

    }
}
