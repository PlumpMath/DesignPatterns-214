using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystemOne Method");
        }
    }

    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystemTwo Method");
        }
    }

    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystemThree Method");
        }
    }

    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("SubSystemFour Method");
        }
    }
}
