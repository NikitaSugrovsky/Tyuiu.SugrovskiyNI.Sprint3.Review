using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SugrovskiyNI.Sprint3.TaskReview.V27.Lib
{
    public class DataService : ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;
                y = Math.Round(y, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;

        }
    }
}
