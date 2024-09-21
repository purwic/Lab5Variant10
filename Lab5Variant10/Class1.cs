using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Variant10
{
    public class Class1
    {
        public static double[,] matrix = new double[7, 5];
        public static double method1()
        {
            double count = 0;
            double sum = 0;
            foreach(var i in matrix)
            {
                if(i >= 0)
                {
                    sum += i;
                    count++;
                }
            }
            if (count != 0) sum /= count;
            return sum;
        }
        public static void method2()
        {
            for (int i = 0; i < 7; i++)
            {
                if (matrix[i, 3] == 6) matrix[i, 3] = 100;
            }
        }
    }
}
