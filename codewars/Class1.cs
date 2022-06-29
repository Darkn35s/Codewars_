using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            List<char> lst=new List<char>();
            foreach(char ch in str)
            {
                if (lst.Contains(ch)) return false;
                lst.Add(ch);
            }
            return true;
        }

        public static string ToCamelCase(string str)
        {
            return str;
        }
    }
}


}
