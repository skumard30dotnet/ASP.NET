using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DemoLinqJoins
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> strList1 = new List<string>() {
                "One",
                "Two",
                "Three",
                "Four"
            };

                        IList<string> strList2 = new List<string>() {
                "One",
                "Two",
                "Five",
                "Six"
            };

            var innerJoin = strList1.Join(strList2,
                                  str1 => str1,
                                  str2 => str2,
                                  (str1, str2) => str1);

            Console.Read();
        }
    }
}
