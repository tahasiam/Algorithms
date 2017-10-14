using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Utilities
    {
        public void IntToBinary(int input)
        {
            List<Int32> binary = new List<Int32>();

            while (input > 0)
            {
                binary.Add(input % 2);
                input = input / 2;
            }
            for (int i = binary.Count - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    }
}
