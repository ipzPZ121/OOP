using System;
using System.IO;
using System.Text;

namespace oop13 {
    class ArrayReader
        : TextReader {
        protected char[] _symbols;
        protected int cursor;
        protected readonly static char endOfString = '\n';
        protected readonly static char endOfText = '\r';

        public virtual char[] SourceArray {
            get{ return _symbols == null ? new char[]{} : _symbols; }
            protected set{ _symbols = value == null ? new char[]{} : value; }
        }

        public ArrayReader(char[] symbols) {
            SourceArray = symbols;
        }

        public override int Read() {
            if(SourceArray.Length == 0)
                return -1;
            if(cursor >= SourceArray.Length)
                return -1;
            return (int)SourceArray[cursor++];
        }

        public override string ReadLine() {
            if(SourceArray.Length == 0)
                return null;
            if(cursor >= SourceArray.Length)
                return null;

            StringBuilder builder = new StringBuilder();
            for(;cursor < SourceArray.Length
                && (SourceArray[cursor] != ArrayReader.endOfString
                && SourceArray[cursor] != ArrayReader.endOfText); Read())
                builder.Append(SourceArray[cursor]);
            Read();

            return builder.ToString();
        }

        public override string ReadToEnd() {
            if(SourceArray.Length == 0)
                return null;
            if(cursor >= SourceArray.Length)
                return null;

            cursor = 0;

            StringBuilder builder = new StringBuilder();
            for(;cursor < SourceArray.Length
                && SourceArray[cursor] != ArrayReader.endOfText; Read())
                builder.Append(SourceArray[cursor]);
            Read();

            return builder.ToString();
        }
    }
}
