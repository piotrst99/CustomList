using P1_CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestCase {
    public interface ITester_IndexOf {

    }

    public class Tester_IndexOf<T> : ITester_IndexOf {
        private CustomList<T> _customList;

        public T[] Items { set { _customList.AddRange(value); } }

        public Tester_IndexOf() {
            _customList = new CustomList<T>();
        }

    }
}
