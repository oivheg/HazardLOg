using System;

namespace HazLog.Data
{
    internal class Data
    {
        private String Name;

        public Data()
        {
            var Name = "DataName";
        }

        public String getName()
        {
            return Name;
        }
    }
}