using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassDemo10._17._19
{
    class Class1
    {
        private int someNumber;
        private string someString;

        public Class1(int num, string str)
        {
            this.someNumber = num;
            this.someString = str;
        }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            if(obj is Class1 && obj != null)
            {
                //comparison
                //create a temp variable
                Class1 temp;
                temp = (Class1)obj;

                if ((temp.someNumber == this.someNumber) &&
                        temp.someString.Equals(this.someString)) return true;
                else return false;
            }
            return false;

        }
    }
}
