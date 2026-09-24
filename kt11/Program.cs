using System;
using System.Collections.Generic;
using System.Text;


namespace kt11 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<IAnimal> animals = new List<IAnimal>
            {
                new Lion("Лев"),
                new Dog("Собака"),
                new Dolphin("Дельфин")
            };
            foreach (var animal in animals)
            {
                Console.WriteLine($"Животное: {animal.Name}");
                animal.MakeSound();
                if (animal is ITrainble trainableAnimal)
                {
                    Console.WriteLine(trainableAnimal.Train());
                }
                Console.WriteLine();
            }
        }
    }
}