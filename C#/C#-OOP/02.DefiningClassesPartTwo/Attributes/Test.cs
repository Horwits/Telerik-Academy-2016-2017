namespace Attributes
{
    using System;
    using Models;

    internal static class Test
    {
        internal static void Main(string[] args)
        {
            Type type = typeof(SampleClass);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
                Console.WriteLine("Version is {0} ", versionAttribute.Version);
            }
        }
    }
}
