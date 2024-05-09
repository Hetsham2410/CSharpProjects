using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begining_Project
{
    static class IntMirror
    {
        public static int  Mirror(this int i)
        {

            var Arr = i.ToString().ToCharArray();
            Array.Reverse(Arr);
            return int.Parse(new string(Arr));
        }
    }
}
