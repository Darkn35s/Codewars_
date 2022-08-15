using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codewars
{
    public class Number
    {
        public int DigitalRoot(long n)
        {
            int result = 0;
            while (n != 0)
            {
                result += (int)(n % 10);
                n=n / 10;
            }
            if (result >= 10) return DigitalRoot(result);
            else return result;
        }
        public int DigitalRoot2(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
    }
    public class BinaryRegex
    {

        public static bool MultipleOf3(string regx)
        {
            double result = 0;
            for(int i = 0; i< regx.Length; i++)
            {
                if(regx[i] == '0' || regx[i] == '1')
                    result += (regx[i] - '0') * Math.Pow(2, i);
                else
                    return false;   
            }
            if (result % 3 == 0)
                return true;
            return false;  
        }
    }


    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return null;
        }
    }

}



