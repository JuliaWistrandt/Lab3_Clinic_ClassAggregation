using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    
    public class Clinic
    {
        public void Run()
        {
            List<Patient> patientsList = new List<Patient>()
            {
                new Patient("John",1),
                new Patient("Maria", 4),
                new Patient("Inger", 2),
                new Patient("Sandra", 3)
            };

            foreach (var pat in patientsList) pat.Healing();

            
        }

    }
}
