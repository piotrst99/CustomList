using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_CustomList {
    public class Point {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj) => this.Equals(obj as Point);

        public bool Equals(Point p) {
            if (p is null) {
                return false;
            }

            if (Object.ReferenceEquals(this, p)) {
                return true;
            }

            if (this.GetType() != p.GetType()) {
                return false;
            }

            return (X == p.X) && (Y == p.Y);
        }
    }
}
