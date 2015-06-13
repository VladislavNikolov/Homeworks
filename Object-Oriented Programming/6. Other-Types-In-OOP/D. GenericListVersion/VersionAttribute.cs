namespace D.GenericListVersion
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
        AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
    class VersionAttribute : Attribute
    {
        public VersionAttribute(byte major, byte minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public byte Major { get; private set; }

        public byte Minor { get; private set; }
    }
}
