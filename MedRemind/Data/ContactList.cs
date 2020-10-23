using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedRemind.Data
{
    public class ContactList
    {
        public Doctor doctor { get; set; }
        public Nurse nurse { get; set; }

       public class Doctor
        {
            public string office { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phoneNumber { get; set; }
        }

        public class Nurse
        {
            public string office { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phoneNumber { get; set; }
        }
    }
}
