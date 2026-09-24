using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt11
{
    public interface ITrainble : IAnimal
    {
        string Train();
    }
    public class Lion : IAnimal
    {
        public string Name { get; private set; }
        public Lion(string name)
        { Name = name; }
        public void MakeSound()
        {
            Console.WriteLine("Ррррррр");
        }
    }
}
