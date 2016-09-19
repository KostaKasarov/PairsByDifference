using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var raz = int.Parse(Console.ReadLine());
            int p = 0;

            for (int i = 0; i < n.Length; i++)
            {
                for (int i1 = 0; i1 < n.Length; i1++)
                {
                    if (n[i] - n[i1] == raz)
                    {
                        p++;
                        
                    }
                    else if (n[i1] - n[i] == -raz)
                    {              
                        p++;                     
                    }
                }
            }
          //  var b = p / 2;
            Console.WriteLine(p);
        }
    }
}
