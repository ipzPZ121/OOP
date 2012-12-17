using System;
using System.Collections;
using System.Text;

namespace oop17 {
    public interface IDataCollection
        : IEnumerable {
        int Count { get; }
        void Push(object item);
        object Pop();
        object Peek();
        Array ToArray();
        bool Contains(object item);
        void Clear();
    }
}
