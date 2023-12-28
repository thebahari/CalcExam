using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CalcExam
{
   public class CalcService
    {
        public int AddNumber(int x, int y)
        {
            return x + y;
        }

        public int SubtractNumber(int x, int y)
        {
            return x - y;
        }

        public int MultiplyNumbers(int x, int y)
        {
            return x * y;
        }

        public bool IsEven(int x)
        {
            if ((x % 2) == 0)
                return true;
            else
            {
                return false;
            }
        }

        public bool IsEvenOrOdd(int x)
        {
            if ((x % 2) == 0)
                return true;
            else
            {
                return false;
            }
        }

        public int UnsafeDivide(int x, int y)
        {
            return (x / y);
        }

        public double SafeDivide(int x, int y)
        {
            double result = 0;
            try
            {
                result =  Convert.ToDouble(x) / y;
            }
            catch (Exception e)
            {
                return -1;
            }

            return result;
        }
    }
}
