using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public class MinMax
    {
        public static int[] minMax(int[] lst)
        {
            int min = lst[0];
            int max = lst[0];
            foreach(int num in lst)
            {
                if(num > min)
                    min = num;
                if(num>max)
                    max = num;
            }
            return new int[] { min, max };
        }
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            // Good Luck!
        }
    }
}
