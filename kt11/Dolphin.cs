using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt11
{
    public class Dolphin : ITrainble
    {
        public string Name { get; private set; }
        public Dolphin(string name)
        {
            Name = name;
        }
        public void MakeSound()
        {
            Console.WriteLine("Свист");
        }
        public string Train()
        {
            return $"{Name}: Держит мяч";
        }
    }
}
