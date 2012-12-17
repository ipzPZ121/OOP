using System;
using System.IO;
using System.Text;

namespace oop13 {
    class ArrayWriter
        : TextWriter {
        protected string _str;
        protected char[] _symbols;
        protected readonly static char endOfText = '\r';
        protected readonly static char endOfString = '\n';
        
        public virtual char[] SourceArray {
            get{ return _symbols == null ? new char[]{} : _symbols; }
            protected set{ _symbols = value == null ? new char[]{} : value; }
        }

        public virtual string Text {
            get{ return _str == null ? string.Empty : _str; }
            protected set{ _str = value == null ? string.Empty : value; }
        }

        public override Encoding Encoding {
            get { throw new NotImplementedException(); }
        }

        public override void Write(char[] symbols) {
            if(symbols == null)
                throw new MyException("char[] symbols == null");
            if(symbols.Length == 0)
                return;

            SourceArray = (new string(SourceArray) 
                + string.Concat(new string(symbols).Split(
                    new char[]{ArrayWriter.endOfText}))).ToCharArray();
            Text = new string(SourceArray);
        }

        public override void WriteLine(char[] symbols) {
            if(symbols == null)
                throw new MyException("char[] symbols == null");
            if(symbols.Length == 0)
                return;

            SourceArray = (new string(SourceArray)
                + string.Concat(new string(symbols).Split(
                    new char[]{ArrayWriter.endOfText}))
                + new string(ArrayWriter.endOfText, 1)
                + new string(ArrayWriter.endOfString, 1)).ToCharArray();
            Text = new string(SourceArray);
        }
    }
}
