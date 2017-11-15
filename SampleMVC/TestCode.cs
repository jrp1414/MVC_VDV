using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC
{
    public class TestCode
    {
        
    }

    public class SomeOtherClass
    {
        public void Test()
        {
            TestCode testCode = new TestCode();
            testCode.MyExt1(5,25);
        }
    }

    public static class ABC
    {
        public static void MyExt1(this TestCode tc,int a,int b)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}",a,b,(a+b));
        }
    }
}