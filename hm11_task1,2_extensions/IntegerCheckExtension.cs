using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm11_task1_2_extensions
{
    internal static class IntegerCheckExtension
    {
        public static bool IntegerCheck(this int value)
        {
            int result = value % 2;
            if (result == 0) { return true; }
            return false;
        }
    }
}
