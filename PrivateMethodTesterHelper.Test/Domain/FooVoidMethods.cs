using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrivateMethodTesterHelper.Test
{
    class FooVoidMethods
    {
        public string fileName;
        public string fileContent;

        private void MyPrivateMethodNoArgs()
        {
            File.WriteAllBytes(fileName, Encoding.ASCII.GetBytes(fileContent));
        }

        private void MyPrivateMethod1Arg(string appendText)
        {
            File.WriteAllBytes(fileName, Encoding.ASCII.GetBytes(s: fileContent + appendText));
        }

        private void MyPrivateMethod2Arg(string appendText, int secondParam)
        {
            File.WriteAllBytes(fileName, Encoding.ASCII.GetBytes(s: fileContent + appendText + " " + secondParam.ToString()));
        }

        private void MyPrivateMethod1ArgObject(List<string> strList)
        {
            string fileContent = "";
            foreach (var str in strList)
                fileContent += str;

            File.WriteAllBytes(fileName, Encoding.ASCII.GetBytes(fileContent));
        }
    }
}
