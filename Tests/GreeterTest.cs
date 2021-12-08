using _03_Classes.Members;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Tests
{
    public class GreeterTest
    {
        [TestMethod]
        public void SayHelloTest()
        {
            GreeterTest greeter = new greeter();
            //                    argument = the value given to a parameter
            greeter.SayHello("Andrew");
            greeter.SayHello("Brandon");
            greeter.SayHello("");


        }

        private void SayHello(string v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator GreeterTest(greeter v)
        {
            throw new NotImplementedException();
        }
    }
}
