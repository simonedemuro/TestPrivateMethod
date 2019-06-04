using System;
using System.Reflection;

namespace PrivateMethodsTestHelper
{
    public class PrivateMethodTester
    {
        public object AccessPrivateMethod(string methodName, object[] args, object obj)
        {
            var mi = obj.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (mi != null)
            {
                return mi.Invoke(obj, args);
            }
            return null;
        }
    }
}
