using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Clinic
{
    internal class Surgeon : Doctor
    {
        public override void Heal()
        {
            WriteLine("Surgeon is healing");
        }
    }
}
