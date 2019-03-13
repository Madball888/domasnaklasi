using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Creature
    {
        public string name;
        public int age;
        public int PowerLevel;
        public bool isTamed;

        public Creature(string name, int age, int PowerLevel, bool isTamed)

        {
            this.name = name;
            this.age = age;
            this.PowerLevel = PowerLevel;
            this.isTamed = isTamed;
        }
    }
}