using System;
using System.Collections.Generic;
using System.Text;

namespace Prashant_Singh
{
    internal class Class3
    {
        Class4 c3 = new Class4();


        public string GetName()
        {
            string str = c3.GetDetails();
            return str;
        }
    }
}
