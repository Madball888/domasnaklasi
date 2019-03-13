using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard[] magic = new Wizard[]
      {
                new Wizard("Neda", 60, 100, new DateTime(1987, 1, 9), false),
                new Wizard("Dina", 63, 41, new DateTime(1988, 1, 9), true),
                new Wizard("Mina", 55, 119, new DateTime(1990, 1, 9), false),
                new Wizard("Lana", 49, 202, new DateTime(1993, 1, 9), false),
                new Wizard("Feya", 61, 184, new DateTime(1983, 1,9), true),
      };
            Creature[] student = new Creature[]
            {
                new Creature("Kirk", 29, 111, false),
                new Creature("Zorg", 37, 75, true),
                new Creature("Mord", 28, 37, false),
                new Creature("Borg", 39, 42, false),
                new Creature("Rork", 22, 28, true),
                new Creature("Loki", 30, 122, true),
            };
            Console.WriteLine("Which creature is tamed by the wizards?\n");
            Console.WriteLine("****************************************\n");
            int i, k;
            for (i = 0; i < magic.Length; i++)
            {
                for (k = 0; k < student.Length; k++)
                {
                    if (magic[i].PowerLevel > student[k].PowerLevel)
                    {
                        Console.WriteLine("Wizard: {0} tamed creature-student: {1}.",
                            magic[i].Name, student[k].name);
                        student[k].isTamed = true;
                    }
                    else
                    {
                        Console.WriteLine("Wizard: {0} didn't tame creature-student: {1}.",
                            magic[i].Name, student[k].name);
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}   
     
