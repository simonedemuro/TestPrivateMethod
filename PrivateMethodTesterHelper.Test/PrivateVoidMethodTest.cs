using PrivateMethodsTestHelper;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace PrivateMethodTesterHelper.Test
{
    public class PrivateVoidMethodTest
    {
        PrivateMethodTester tester;

        public PrivateVoidMethodTest()
        {
            tester = new PrivateMethodTester();

        }

        [Fact]
        public void PrivateVoidNoArgs_Test()
        {
            // SETUP
            FooVoidMethods fooObject = new FooVoidMethods()
            {
                fileName = "PrivateVoidNoArgs_Test.txt",
                fileContent = "Test run: " + DateTime.Now.ToString()
            };

            // EXERCISE
            tester.AccessPrivateMethod("MyPrivateMethodNoArgs", null, fooObject);

            // ASSERT
            if (!File.Exists(fooObject.fileName))
            {
                Assert.True(false, "PrivateVoidNoArgs_Test didn't ran correctly");
            }

            // CLEANUP
            File.Delete(fooObject.fileName);
        }
        [Fact]
        public void PrivateVoid1Args_Test()
        {
            // SETUP
            FooVoidMethods fooObject = new FooVoidMethods()
            {
                fileName = "PrivateVoid1Args_Test.txt",
                fileContent = "Test run: " + DateTime.Now.ToString()
            };
            object[] methodArguments = new object[]
            {
                "This is the argument passed to the method"
            };

            // EXERCISE
            tester.AccessPrivateMethod("MyPrivateMethod1Arg", methodArguments, fooObject);

            // ASSERT
            if (!File.Exists(fooObject.fileName))
            {
                Assert.True(false, "PrivateVoid1Args_Test didn't ran correctly");
            }

            // CLEANUP
            File.Delete(fooObject.fileName);
        }
        [Fact]
        public void PrivateVoid2Args_Test()
        {
            // SETUP
            FooVoidMethods fooObject = new FooVoidMethods()
            {
                fileName = "PrivateVoid2Args_Test.txt",
                fileContent = "Test run: " + DateTime.Now.ToString()
            };
            int myIntParam = 10;
            object[] methodArguments = new object[]
            {
                "This is the argument passed to the method",
                myIntParam
            };

            // EXERCISE
            tester.AccessPrivateMethod("MyPrivateMethod2Arg", methodArguments, fooObject);

            // ASSERT
            if (!File.Exists(fooObject.fileName))
            {
                Assert.True(false, "PrivateVoid2Args_Test didn't ran correctly");
            }

            // CLEANUP
            File.Delete(fooObject.fileName);
        }
        [Fact]
        public void PrivateVoidObjectArgs_Test()
        {
            // SETUP
            FooVoidMethods fooObject = new FooVoidMethods()
            {
                fileName = "MyPrivateMethod1ArgObject.txt",
                fileContent = "Test run: " + DateTime.Now.ToString()
            };
            List<string> myInputParamList = new List<string>()
            {
                "This ",
                "is an example of object passed as parameter"
            };
            object[] methodArguments = new object[]
            {
                myInputParamList
            };

            // EXERCISE
            tester.AccessPrivateMethod("MyPrivateMethod1ArgObject", methodArguments, fooObject);

            // ASSERT
            if (!File.Exists(fooObject.fileName))
            {
                Assert.True(false, "PrivateVoidObjectArgs_Test didn't ran correctly");
            }

            // CLEANUP
            File.Delete(fooObject.fileName);
        }
    }
}
