using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UXI.GazeToolkit.Utils
{
    public static class MathUtils
    {
        public static double ConvertDegToRad(double angle)
        {
            return Math.PI * angle / 180d;
        }


        public static double ConvertRadToDeg(double angle)
        {
            return angle * (180d / Math.PI);
        }


        public static double WrapAround(double value, double modulo)
        {
            return (value + modulo) % modulo;
        }


        public static double? RMS(IEnumerable<double> values)
        {
            return values.Count() > 1
                 ? (double?)Math.Sqrt(values.Average(v => Math.Pow(v, 2))) 
                 : null;
        }


        public static double Average(IEnumerable<double> points)
        {
            var reference = points.First();
            var aggregate = 0d;

            var rest = points.Skip(1);
            int count = 1;

            foreach (var point in rest)
            {
                aggregate += point - reference;
                count++;
            }

            double average = reference + aggregate / count;

            return average;
        }
    }
}
