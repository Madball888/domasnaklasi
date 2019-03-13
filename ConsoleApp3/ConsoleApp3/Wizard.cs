using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Wizard
    {
        public string Name;
        public int PowerLevel;
        public int Age;
        public DateTime DateOfAdmission { get; set; }
        public bool GraduationStatus;
       
    

    public Wizard(string Name, int PowerLevel, int Age, DateTime DateOfAdmission, bool GraduationStatus)

    {
        this.Name = Name;
        this.PowerLevel = PowerLevel;
        this.Age = Age;
        this.DateOfAdmission = DateOfAdmission;
        this.GraduationStatus = GraduationStatus;
    }
}


}

