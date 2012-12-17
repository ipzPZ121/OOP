using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop13 {
    class MyBigInteger {
        private int[] _bigInt;
        private char _oct;
        private static readonly int SIZE = 1000;
        protected static readonly char negativeOct = '-';
        protected static readonly char positiveOct = '+';

        public virtual string Number {
            get {
                if (_bigInt == null || _bigInt.Length == 0) {
                    return string.Empty;
                }

                StringBuilder builder = new StringBuilder();
                if (_oct == MyBigInteger.negativeOct) {
                    builder.Append(MyBigInteger.negativeOct);
                }

                foreach (int n in _bigInt) {
                    builder.Append(n);
                }

                return builder.ToString();
            }

            set {
                int start;

                if (value == null || value == string.Empty) {
                    _bigInt = new int[] { 0 };
                    return;
                }

                if (value[0] == MyBigInteger.negativeOct) {
                    if (value.Length > SIZE + 1) {
                        throw new ApplicationException("Input number more 1000 digits of lenght");
                    }
                    _oct = value[0];
                    start = 1;
                } else {
                    if (value.Length > SIZE) {
                        throw new ApplicationException("Input number more 1000 digits of lenght");
                    }
                    start = 0;
                }

                _bigInt = new int[value.Length - start];
                for (int i = 0; i < _bigInt.Length; i++) {
                    _bigInt[i] = int.Parse(new string(value[i + start], 1));
                }
            }
        }

        public virtual int[] Module {
            get {
                if (_bigInt == null || _bigInt.Length == 0)
                    return new int[] { 0 };
                int[] tmp = new int[_bigInt.Length];
                Array.Copy(_bigInt, tmp, tmp.Length);

                return tmp;
            }
        }

        public virtual char Octothorpe {
            get { return _oct == '\0' ? MyBigInteger.positiveOct : _oct; }
            protected set { _oct = value == '\0' ? MyBigInteger.positiveOct : MyBigInteger.negativeOct; }
        }

        public MyBigInteger()
            : this(string.Empty) {
        }

        public MyBigInteger(string bigInt) {
            this.Number = bigInt;
        }

        public MyBigInteger(MyBigInteger bigInt)
            : this(bigInt.Number) {
        }

        public MyBigInteger Sum(MyBigInteger bigInt) {
            if (Octothorpe == MyBigInteger.positiveOct && bigInt.Octothorpe == MyBigInteger.negativeOct) {
                MyBigInteger tmp = BuildBigInteger(bigInt.Module, MyBigInteger.positiveOct);
                return Sub(tmp);
            } else if (Octothorpe == MyBigInteger.negativeOct && bigInt.Octothorpe == MyBigInteger.positiveOct) {
                MyBigInteger tmp = BuildBigInteger(Module, MyBigInteger.positiveOct);
                return bigInt.Sub(tmp);
            } else if (Octothorpe == MyBigInteger.negativeOct && bigInt.Octothorpe == MyBigInteger.negativeOct) {
                MyBigInteger tmp = BuildBigInteger(bigInt.Module, MyBigInteger.positiveOct);
                return Sub(tmp);
            }

            int[] buff = new int[MyBigInteger.SIZE];
            int[] bufTmp1;
            int[] bufTmp2;
            InitBuffers(Module, bigInt.Module, out bufTmp1, out bufTmp2, MyBigInteger.SIZE);

            int inMind = 0;
            char oct = MyBigInteger.positiveOct;

            for (int i = MyBigInteger.SIZE - 1; i >= 0; i--) {
                if ((bufTmp1[i] + bufTmp2[i] + inMind) < 10) {
                    buff[i] = bufTmp1[i] + bufTmp2[i] + inMind;
                    inMind = 0;
                } else {
                    buff[i] = (bufTmp1[i] + bufTmp2[i] + inMind) % 10;
                    inMind = (bufTmp1[i] + bufTmp2[i] + inMind) / 10;
                }
            }

            return BuildBigInteger(buff, oct);
        }

        public MyBigInteger Sub(MyBigInteger bigInt) {
            if (Octothorpe == MyBigInteger.positiveOct && bigInt.Octothorpe == MyBigInteger.negativeOct) {
                MyBigInteger tmp = BuildBigInteger(bigInt.Module, MyBigInteger.positiveOct);
                return Sum(tmp);
            } else if (Octothorpe == MyBigInteger.negativeOct && bigInt.Octothorpe == MyBigInteger.positiveOct) {
                MyBigInteger tmp1 = BuildBigInteger(Module, MyBigInteger.positiveOct);
                MyBigInteger tmp2 = tmp1.Sum(bigInt);
                return BuildBigInteger(tmp2.Module, MyBigInteger.negativeOct);
            } else if (Octothorpe == MyBigInteger.negativeOct && bigInt.Octothorpe == MyBigInteger.negativeOct) {
                MyBigInteger tmp1 = BuildBigInteger(Module, MyBigInteger.positiveOct);
                MyBigInteger tmp2 = BuildBigInteger(bigInt.Module, MyBigInteger.positiveOct);
                return tmp2.Sub(tmp1);
            }

            int[] buff = new int[MyBigInteger.SIZE];
            int[] bufTmp1;
            int[] bufTmp2;
            InitBuffers(Module, bigInt.Module, out bufTmp1, out bufTmp2, MyBigInteger.SIZE);

            int inMind = 0;
            char oct = MyBigInteger.positiveOct;

            if (CompareTo(bigInt) > 0) {
                for (int i = MyBigInteger.SIZE - 1; i >= 0; i--) {
                    if ((bufTmp1[i] + inMind) >= bufTmp2[i]) {
                        buff[i] = bufTmp1[i] - bufTmp2[i] + inMind;
                        inMind = 0;
                    } else {
                        buff[i] = bufTmp1[i] + 10 - bufTmp2[i] + inMind;
                        inMind = -1;
                    }
                }
            } else if (CompareTo(bigInt) < 0) {
                for (int i = MyBigInteger.SIZE - 1; i >= 0; i--) {
                    if ((bufTmp2[i] + inMind) >= bufTmp1[i]) {
                        buff[i] = bufTmp2[i] - bufTmp1[i] + inMind;
                        inMind = 0;
                    } else {
                        buff[i] = bufTmp2[i] + 10 - bufTmp1[i] + inMind;
                        inMind = -1;
                    }
                }
                oct = MyBigInteger.negativeOct;
            }

            return BuildBigInteger(buff, oct);
        }

        public int CompareTo(MyBigInteger bigInt) {
            int result = 0;
            if (bigInt.Octothorpe == MyBigInteger.negativeOct && Octothorpe == MyBigInteger.positiveOct)
                return 1;
            else if (Octothorpe == MyBigInteger.negativeOct && bigInt.Octothorpe == MyBigInteger.positiveOct)
                return -1;
            else if (Module.Length > bigInt.Module.Length)
                return 1;
            else if (Module.Length < bigInt.Module.Length)
                return -1;
            else if (Module.Length == bigInt.Module.Length) {
                for (int i = 0; i < Module.Length; i++) {
                    if (Module[i] > bigInt.Module[i])
                        return 1;
                    else if (Module[i] < bigInt.Module[i])
                        return -1;
                }
            }

            return result;
        }

        protected virtual MyBigInteger BuildBigInteger(int[] module, char oct) {
            int pos = 0;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < module.Length; i++, pos++) {
                if (module[i] != 0)
                    break;
            }

            if (oct == MyBigInteger.negativeOct)
                builder.Append(MyBigInteger.negativeOct);

            for (int i = pos; i < module.Length; i++)
                builder.Append(module[i]);

            MyBigInteger b = new MyBigInteger();
            b.Number = builder.ToString();

            return b;
        }

        protected virtual void InitBuffers(int[] in1, int[] in2, out int[] out1, out int[] out2, int size) {
            out1 = new int[size];
            out2 = new int[size];

            int module_pos = in1.Length - 1;
            for (int i = out1.Length - 1; module_pos >= 0; i--, module_pos--) {
                out1[i] = in1[module_pos];
            }

            module_pos = in2.Length - 1;
            for (int i = out2.Length - 1; module_pos >= 0; i--, module_pos--) {
                out2[i] = in2[module_pos];
            }
        }

        public override bool Equals(object obj) {
            MyBigInteger bigInt = obj as MyBigInteger;

            return (CompareTo(bigInt) == 0);
        }
    }
}
