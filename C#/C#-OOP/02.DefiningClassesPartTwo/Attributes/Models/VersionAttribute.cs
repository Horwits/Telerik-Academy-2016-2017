namespace Attributes.Models
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class VersionAttribute : Attribute
    {
        private string version;

        public VersionAttribute(uint major, uint minor)
        {
            this.version = string.Format("{0}.{1}", major, minor);
        }

        public string Version
        {
            get
            {
                return this.version;
            }
        }
    }
}
