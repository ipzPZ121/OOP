using System;
using System.Collections;
using System.Text;

namespace oop17 {
    class Queue
        : IQueue {
        private _Enumerator _enumerator;

        private _Enumerator Enumerator {
            get { return _enumerator == null ? new _Enumerator(_Enumerator.Null) : _enumerator; }
            set { _enumerator = value == null ? new _Enumerator(_Enumerator.Null) : value; }
        }

        public int Count {
            get { return Enumerator.Data == null ? _Enumerator.Null : Enumerator.Data.Count; }
        }

        public Queue()
            : this(_Enumerator.Null) {
        }

        public Queue(int initSize) {
            _enumerator = new _Enumerator(initSize);
        }

        public Queue(Array arr)
            : this(arr.Length) {
            foreach(object obj in arr) {
                Enumerator.Data.Add(obj);
            }
        }

        public Queue(Stack stack)
            : this(stack.ToArray()) {
        }

        public IEnumerator GetEnumerator() {
            return _enumerator;
        }

        public void Push(object item) {
            Enumerator.Data.Insert(_Enumerator.Top, item);
            _Enumerator.Bottom = _Enumerator.CalculateEnumeratorBottom(Enumerator.Data.Count);
        }

        public object Pop() {
            object tmp = Enumerator.Data[_Enumerator.Bottom];
            Enumerator.Data.RemoveAt(_Enumerator.Bottom);
            _Enumerator.Bottom = _Enumerator.CalculateEnumeratorBottom(Enumerator.Data.Count);
            return tmp;
        }

        public object Peek() {
            return Enumerator.Data[_Enumerator.Top];
        }

        public Array ToArray() {
            return Enumerator.Data.ToArray();
        }

        public bool Contains(object item) {
            return Enumerator.Data.Contains(item);
        }

        public void Clear() {
            Enumerator.Data.Clear();
        }

        private class _Enumerator
            : IEnumerator {
            private ArrayList _data;
            private int _cursor;
            private object _current;

            public ArrayList Data {
                get { return _data; }
                private set { _data = value; }
            }

            public static int Top {
                get { return 0; }
            }

            public static int Bottom {
                get; set;
            }

            public static int Null {
                get { return 0; }
            }

            private int Cursor {
                get { return _cursor; }
                set { _cursor = value < 0 ? 0 : value; }
            }

            private object SetCurrent {
                set { _current = value == null ? new object() : value; }
            }

            public _Enumerator(int initSize) {
                Data = new ArrayList(initSize);
                Cursor = _Enumerator.Top;
            }

            public object Current {
                get { return _current; }
            }

            public bool MoveNext() {
                if(Cursor >= Data.Count) {
                    Reset();
                    return false;
                }
                SetCurrent = Data[Cursor];
                Cursor++;
                return true;
            }

            public void Reset() {
                Cursor = _Enumerator.Top;
            }

            public static int CalculateEnumeratorBottom(int dataSize) {
                return dataSize - 1;
            }
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append("[");
            foreach(object obj in this) {
                builder.Append(obj);
                builder.Append("  ");
            }
            builder.Append("]");

            return builder.ToString();
        }
    }
}
