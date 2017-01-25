using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatzSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            long largestCollNum = 0;
            long lastCollSeq = 0;
            long CollSeq = 0;
            long collNum = 0;
            for (int number = 2; number < 1000000; number++)
            {
                CollSeq = 1;
                collNum = number;
                while (collNum != 1)
                {
                    if (collNum %2 == 0)
                    {
                        collNum = collNum / 2;
                        CollSeq++;

                    }
                    else
                    {
                        collNum = (collNum * 3) + 1;
                        CollSeq++;

                    }
                }
                if (CollSeq > lastCollSeq)
                {
                    lastCollSeq = CollSeq;
                    largestCollNum = number;
                }
            }
            Console.WriteLine(largestCollNum);
            Console.WriteLine(lastCollSeq);
            Console.ReadKey();
        }
    }
}
