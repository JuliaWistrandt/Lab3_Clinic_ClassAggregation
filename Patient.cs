using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace Clinic
{
    public class Patient
    {

        string name;
        public TreatmentPlan treatmentPlan;

        public Patient(string name, int index)
        {
            this.name = name;
            treatmentPlan = new TreatmentPlan(index);
            treatmentPlan.index = index;
        }
        public void Healing()
        {
            if (treatmentPlan.index == 1)
            {
                var doctor = new Surgeon();
                doctor.Heal();
                WriteLine($"Patient name: {name}\nDoctor: {doctor}\n");
            }
            else if (treatmentPlan.index == 2)
            {
                var doctor = new Dentist();
                doctor.Heal();
                WriteLine($"Patient name: {name}\nDoctor: {doctor}\n");
            }
            else if (treatmentPlan.index == 3)
            {
                var doctor = new Therapist();
                doctor.Heal();
                WriteLine($"Patient name: {name}\nDoctor:{doctor}\n");
            }
            else WriteLine($"Oops, looks like there is no such\ntreatment index ({treatmentPlan.index}) in our Hospital.\nPlease pick a number between 1 and 3.\n");
        }
        
    }
}
