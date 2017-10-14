using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            CallForBinary();
            Console.ReadLine();
        }
        
        public static void CallForBinary()
        {
            Utilities util = new Utilities();
            Console.Write("Please enter  a integer value : ");
            int input =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("The Binary equivalent is : ");
            util.IntToBinary(input);
        }
    }
    
}
