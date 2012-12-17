using System;
using System.Collections.Generic;
using System.Text;

namespace oop19 {
    class Set<Tv> : Dictionary<int, Tv> where Tv: IComparable {
        public Set()
            : base() {
        }

        private new void Add(int key, Tv value) {
            base.Add(key, value);
        }

        public void Add(Tv value) {
            if(ContainsKey(value.GetHashCode()))
                throw new ApplicationException("Word is exist");
            
            Add(value.GetHashCode(), value);
        }

        public Set<Tv> Sum(Set<Tv> set) {
            

            return null;
        }
    }
}
