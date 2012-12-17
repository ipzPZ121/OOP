using System;

    class ComplexNumber
    {
        double r;
        double i;

        public ComplexNumber(double Re, double Im)
        {
            r = Re;
            i = Im;
        }

        public void Print()
        {
            if (i >= 0)
            {
                Console.WriteLine(r + " + " + i + "i");
            }
            else
            {
                i = -i;
                Console.WriteLine(r + " - " + i + "i");
            }
        }

        public void Sum (double Re,double Im)
        {
            r += Re;
            i += Im;
        }

        public void Mul(double Re, double Im)
        {
            r = r * Re + i * Im;
            i = r * Im + i * Re;
        }

    }
