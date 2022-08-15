namespace codewars
{
    public class Kata
    {
        public static bool is_valid_IP(string ipAddres)
        {
            var data=ipAddres.Split('.');
            if (data.Length != 4) 
                return false;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(data[i]+"-");
                if (data[i].Length > 3 || data[i].Length < 1) 
                    return false;
                
                if (data[i][0] == '0' && data[i].Length > 1) 
                    return false;

                for (int j = 0; j < data[i].Length; j++)
                    if ((data[i][j] + 0) < 48 || (data[i][j] + 0) > 57)
                        return false;
                try
                {

                    if ((Int32.Parse(data[i]) > 255)||(Int32.Parse(data[i]) < 0))
                        return false;
                }
                catch { return false; }
                   
                    
            }
            return true;  
        }
        
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

        public static int[] Divisors(int n)
        {
            
                List<int> div = new List<int>();

                for (int i = 2; i <=n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        div.Add(i);
                    }
                }
                return div.ToArray();
            
            
        }
        public static string Collatz(int n)
        {
           string output = "";
           while (n != 1)
           {
                output += n.ToString()+"->";
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = 3 * n + 1;
           }
           output += "1";
           return output;
        }



        public static string AlphabetPosition(string text)
        {
            string numtxt = "";
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] + 0) > 64 && (text[i] + 0) < 91)
                {
                    numtxt += text[i] - 64+" ";
                }
                if ((text[i] + 0) > 96 && (text[i] + 0) < 123)
                {
                    numtxt += text[i] - 96+" ";
                }
               
            }
            if (numtxt.Length > 0)
                numtxt = numtxt.Remove(numtxt.Length - 1);
            return numtxt;
        }
    }

    

}



