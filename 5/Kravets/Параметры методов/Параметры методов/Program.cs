using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Параметры_методов
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private double[] getThreeBest(out double[] sprints, params double[] input)
        {
            if (input.Length < 3)
                throw new ArgumentOutOfRangeException();
            Array.Sort(input);
            sprints = new double[3];
            Array.Copy(input, sprints, sprints.Length);
            return sprints;
        }
    }
}
