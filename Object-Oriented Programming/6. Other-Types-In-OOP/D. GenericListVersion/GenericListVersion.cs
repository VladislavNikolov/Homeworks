namespace D.GenericListVersion
{
    using System;
    using C.GenericList;

    class GenericListVersion
    {
        static void Main(string[] args)
        {
            Type type = typeof(GenericList<>);
            object[] versionAttributes = type.GetCustomAttributes(typeof(VersionAttribute), true);
            foreach (VersionAttribute attribute in versionAttributes)
            {
                Console.WriteLine("Version: " + attribute.Major + "." + attribute.Minor);
            }
        }
    }
}
