using System;
using System.Collections.Generic;
using System.Text;

namespace PassByValueReferenceOut
{
    class EvenOddFinderLogic
    {
        public static bool IsEvenOrOdd(int data)
        {
            if (data % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
