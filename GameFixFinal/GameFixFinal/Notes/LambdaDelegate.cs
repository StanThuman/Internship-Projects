using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameFixFinal.Notes
{
    public class LambdaDelegate
    {

        delegate int MyDelegate(int x);
        

        public void doSomething()
        {

            MyDelegate myDel = (x) => x + 5;
            int result = myDel(4);


            
        }

    }
}