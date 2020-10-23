using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace MedRemind.Data
{
    public class Medications
    {
        public string name { get; set; }
        public int totalMeds { get; set; }
        public string timeToTake { get; set; }
        public string miligrams { get; set; }
        public Boolean tookToday { get; set; }
    }
}
