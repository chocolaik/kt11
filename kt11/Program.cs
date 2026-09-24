using System;
using System.Collections.Generic;
using System.Text;

public interface IAnimal
{
    string Name { get; }
    void MakeSound();
}

public interface ITrainble : IAnimal
{
    string Train();
}
public class Lion : IAnimal
{
    public string Name { get; private set; }
    public Lion(string name)
    {  Name = name; }
    public void MakeSound()
    {
        Console.WriteLine("Ррррррр");
    }
}

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