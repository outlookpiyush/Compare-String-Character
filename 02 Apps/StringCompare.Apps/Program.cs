using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Logic;

namespace StringCompare.Apps
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputFirstString = Convert.ToString(Console.ReadLine());
            var inputSecondString = Convert.ToString(Console.ReadLine());
            var charCompareFromString = new CharCompareFromString();

            Console.WriteLine($"Both The String Character Index and Character are Same Count As {charCompareFromString.GetCharacterCount(inputFirstString, inputSecondString)}");
            Console.ReadLine();

        }
    }
}
