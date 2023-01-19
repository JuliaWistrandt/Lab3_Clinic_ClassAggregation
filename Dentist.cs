using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Clinic
{
    internal class Dentist : Doctor
    {
        public override void Heal()
        {
            WriteLine("Dentist is healing");
        }
    }
}
