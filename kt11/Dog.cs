using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt11
{
    public class Dog : ITrainble
    {
        public string Name { get; private set; }
        public Dog(string name)
        {
            Name = name;
        }
        public void MakeSound()
        {
            Console.WriteLine("Гав");
        }
        public string Train()
        {
            return $"{Name}: Бегает за костью";
        }
    }
}
