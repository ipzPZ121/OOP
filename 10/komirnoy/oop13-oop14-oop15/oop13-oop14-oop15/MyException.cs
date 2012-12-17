using System;
using System.Text;

namespace oop13 {
    class MyException
        : ApplicationException {
        public MyException()
            : base("Array cannot be a null") {
        }

        public MyException(string message)
            : base(message) {
        }
    }
}
