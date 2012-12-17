using System;
using System.Collections;
using System.Text;

namespace oop18 {
    class MyDictionary
        : IDictionary {
        private _DictionaryEnumerator _dictionaryEnumerator;

        private _DictionaryEnumerator DictionaryEnumerator {
            get { return _dictionaryEnumerator == null ? new _DictionaryEnumerator(_DictionaryEnumerator.Null) : _dictionaryEnumerator; }
            set { _dictionaryEnumerator = value == null ? new _DictionaryEnumerator(_DictionaryEnumerator.Null) : value; }
        }

        public int Count {
            get { return DictionaryEnumerator.Size; }
        }

        public bool IsFixedSize {
            get { return false; }
        }

        public bool IsReadOnly {
            get { return false; }
        }

        public ICollection Keys {
            get { return new ArrayList(DictionaryEnumerator.Keys); }
        }

        public ICollection Values {
            get { return new ArrayList(DictionaryEnumerator.Values); }
        }

        public object this[object key] {
            get {
                return DictionaryEnumerator.Values[DictionaryEnumerator.Keys.IndexOf(key)];
            }
            set {
                if(DictionaryEnumerator.Keys.Contains(key))
                    DictionaryEnumerator.Values[DictionaryEnumerator.Keys.IndexOf(key)] = value == null ? new object() : value;
                else
                    Add(key, value == null ? new object() : value);
            }
        }

        public bool IsSynchronized {
            get { return false; }
        }

        public object SyncRoot {
            get { return null; }
        }

        public MyDictionary()
            : this(_DictionaryEnumerator.Null) {
        }

        public MyDictionary(int initSize) {
            _dictionaryEnumerator = new _DictionaryEnumerator(initSize);
        }

        public MyDictionary(ArrayList keys, ArrayList values)
            : this(keys.Count) {
            if(keys.Count != values.Count)
                throw new ApplicationException("Keys and Values don\'t have same size");
            
            for(int i = 0; i < keys.Count; i++) {
                if(DictionaryEnumerator.Keys.Contains(keys[i]))
                    continue;
                DictionaryEnumerator.Keys.Add(keys[i]);
                DictionaryEnumerator.Values.Add(values[i]);
            }

            DictionaryEnumerator.Keys.TrimToSize();
            DictionaryEnumerator.Values.TrimToSize();
        }

        public void Add(object key, object value) {
            if(DictionaryEnumerator.Keys.Contains(key))
                throw new ApplicationException("Key is exist");
            if(key == null)
                throw new ApplicationException("Key is null");
            if(value == null)
                throw new ApplicationException("Value is null");

            DictionaryEnumerator.Keys.Add(key);
            DictionaryEnumerator.Values.Add(value);
        }

        public void Clear() {
            DictionaryEnumerator.Keys.Clear();
            DictionaryEnumerator.Values.Clear();
        }

        public bool Contains(object key) {
            return DictionaryEnumerator.Keys.Contains(key);
        }

        public IDictionaryEnumerator GetEnumerator() {
            return DictionaryEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return DictionaryEnumerator as IEnumerator;
        }

        public void Remove(object key) {
            int index = DictionaryEnumerator.Keys.IndexOf(key);
            DictionaryEnumerator.Keys.RemoveAt(index);
            DictionaryEnumerator.Values.RemoveAt(index);
        }

        public void CopyTo(Array array, int index) {
            int count = index < 0 ? 0 : index;
            DictionaryEntry[] tmp = new DictionaryEntry[DictionaryEnumerator.Size];
            for(int i = count; i < DictionaryEnumerator.Size; i++) {
                tmp[i - count] = new DictionaryEntry(DictionaryEnumerator.Keys[i], DictionaryEnumerator.Values[i]);
            }

            array = new DictionaryEntry[DictionaryEnumerator.Size];
            Array.Copy(tmp, array, tmp.Length);
        }

        private class _DictionaryEnumerator
            : IDictionaryEnumerator {
            private ArrayList _keys;
            private ArrayList _values;
            private int _cursor;
            private DictionaryEntry _current;

            public ArrayList Keys {
                get { return _keys; }
                private set { _keys = value; }
            }

            public ArrayList Values {
                get { return _values; }
                private set { _values = value; }
            }

            public DictionaryEntry Entry {
                get { return (DictionaryEntry)Current; }
            }

            public object Key {
                get { return Keys[Cursor]; }
            }

            public object Value {
                get { return Values[Cursor]; }
            }

            public object Current {
                get { return _current; }
            }

            public static int Null {
                get { return 0; }
            }

            private int Cursor {
                get { return _cursor; }
                set { _cursor = value < 0 ? 0 : value; }
            }

            private DictionaryEntry SetCurrent {
                set { _current = value; }
            }

            public int Size {
                get { return Keys.Count; }
            }

            public _DictionaryEnumerator(int initSize) {
                Init(initSize);
            }

            public bool MoveNext() {
                if(Cursor >= Size) {
                    Reset();
                    return false;
                }
                SetCurrent = new DictionaryEntry(Key, Value);
                Cursor++;
                return true;
            }

            public void Reset() {
                Cursor = _DictionaryEnumerator.Null;
            }

            private void Init(int initSize) {
                Keys = new ArrayList(initSize);
                Values = new ArrayList(initSize);
                Cursor = _DictionaryEnumerator.Null;
            }
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append("{\n");
            foreach(object obj in this) {
                DictionaryEntry tmp = (DictionaryEntry)obj;
                builder.Append(string.Format("\t[ key: {0}; value: {1} ]", tmp.Key, tmp.Value));
                builder.Append("\n");
            }
            builder.Append("}");

            return builder.ToString();
        }
    }
}
