using PrivateMethodsTestHelper;
using PrivateMethodTesterHelper.Test.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace PrivateMethodTesterHelper.Test
{
    public class PrivateMethodTest
    {
        PrivateMethodTester tester;

        public PrivateMethodTest()
        {
            tester = new PrivateMethodTester();
        }

        [Fact]
        public void PrivateNoArgs_Test()
        {
            // SETUP
            FooMethods fooObject = new FooMethods();
            
            // EXERCISE
            string myPrivateMethodResult = (string) tester.AccessPrivateMethod("ReturnHelloWorld", null, fooObject);

            // ASSERT
            Assert.Equal("Hello World", myPrivateMethodResult);
        }
    }
}
