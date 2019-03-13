using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your text");
            List<string> exctude = new List<string> { "is", "a", "the", "an", "are", "i", "but", "by", "to", "of", "we", "have", "has", "and", "that", "this", "out", "do", "all", "not", "am"};
            string text = Console.ReadLine();
            char[] splitChar = { ' ', ',', '"', '.', '\'' };
            String[] tages = text.ToLower().Split(splitChar);
            Dictionary<String, int> tacs = new Dictionary<string, int>();
            bool B;
            foreach (string c in tages)
            {
                B = false;
                foreach(string e in exctude)
                {
                    if ((c == e) || (c.Trim().Length == 0))
                    {
                        B = true;
                        break;
                    }
                }
                if (B) continue;
                if (!tacs.Keys.Contains(c))
                {
                    tacs[c] = 1;
                }
                else
                {
                    tacs[c] = tacs[c] + 1;
                }

            }
            List<string> s = new List<string>();
            int max = 0;
            foreach (var v in tacs.ToArray())
            {
                if(tacs[v.Key] > max)
                {
                    //s.Add(v.Key);
                    max = tacs[v.Key];
                }
            }

            foreach (var v in tacs.ToArray())
            {
                if (tacs[v.Key] == max)
                {
                    s.Add(v.Key);
                }
            }

            foreach (string c in s)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}
