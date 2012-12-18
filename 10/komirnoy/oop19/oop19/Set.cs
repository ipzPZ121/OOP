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

        public void AddWord(Tv value) {
            if(ContainsKey(value.GetHashCode()))
                throw new ApplicationException("Word is exist");
            
            Add(value.GetHashCode(), value);
        }

        public Set<Tv> Sum(Set<Tv> set) {
            Set<Tv> tmp = new Set<Tv>();
            foreach(Tv v in Values) {
                tmp.AddWord(v);
            }

            foreach(Tv v in set.Values) {
                if(tmp.ContainsKey(v.GetHashCode()))
                    continue;
                tmp.AddWord(v);
            }

            return tmp;
        }

        public Set<Tv> Sub(Set<Tv> set) {
            Set<Tv> tmp = new Set<Tv>();
            foreach(Tv v in Values) {
                tmp.AddWord(v);
            }

            foreach(Tv v in set.Values) {
                if(tmp.ContainsKey(v.GetHashCode()))
                    tmp.Remove(v.GetHashCode());
            }

            return tmp;
        }

        public Set<Tv> Intersect(Set<Tv> set) {
            Set<Tv> tmp = new Set<Tv>();
            foreach (Tv v in Values) {
                if(set.ContainsKey(v.GetHashCode()))
                    tmp.AddWord(v);
            }

            //foreach(Tv v in set.Values) {
            //    if(!tmp.ContainsKey(v.GetHashCode()))
            //        tmp.Remove(v.GetHashCode());
            //}

            return tmp;
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append("[ ");
            foreach(Tv v in Values) {
                builder.Append(v);
                builder.Append(" ");
            }
            builder.Append(" ]");

            return builder.ToString();
        }
    }
}
