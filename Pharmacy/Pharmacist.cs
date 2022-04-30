using System;

namespace Pharmacy
{
    public class Pharmacist
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Experience { get; set; }
        public Pharmacist(string name, DateTime birth, int exp)
        {
            FullName = name;
            BirthDate = birth;
            Experience = exp;
        }
    }
}
