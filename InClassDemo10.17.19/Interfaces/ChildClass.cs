using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ChildClass : BaseClass, Interface2
    {
        public override void I1Method()
        {
            //base.I1Method();
            Console.WriteLine("I1 method ia child");
        }

        public int I2Method(int num)
        {
            return num;
        }
    }
}
