using System;

namespace HRM.Models
{
    internal class ForeignkeyAttribute : Attribute
    {
        private string v;

        public ForeignkeyAttribute(string v)
        {
            this.v = v;
        }
    }
}