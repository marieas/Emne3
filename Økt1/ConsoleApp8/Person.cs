using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Person
    {
        public int Age { get; set; } = 55;
        public string Name { get; set; }

        public void Birthday()
        {
            Age++;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
