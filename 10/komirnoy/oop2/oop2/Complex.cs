using System;

namespace oop2 {
    class Complex {
        public float real;
        public float imagin;

        public Complex Sum(Complex complex) {
            Complex tmp = new Complex();
            tmp.real = real + complex.real;
            tmp.imagin = imagin + complex.imagin;

            return tmp;
        }

        public Complex Sub(Complex complex) {
            Complex tmp = new Complex();
            tmp.real = real - complex.real;
            tmp.imagin = imagin - complex.imagin;

            return tmp;
        }

        public Complex Mul(Complex complex) {
            Complex tmp = new Complex();
            tmp.real = real * complex.real - imagin * complex.imagin;
            tmp.imagin = imagin * complex.real + real * complex.imagin;

            return tmp;
        }

        public Complex Div(Complex complex) {
            Complex tmp = new Complex();
            tmp.real = (real * complex.real + imagin * complex.imagin)
                / (complex.real * complex.real + complex.imagin * complex.imagin);
            tmp.imagin = (imagin * complex.real - real * complex.imagin)
                / (complex.real * complex.real + complex.imagin * complex.imagin);

            return tmp;
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", real, imagin);
        }
    }
}
