using System;

namespace code_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============ANIMAL SHELTER==============");
            AnimalShelter animalShelter = new AnimalShelter();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Cat cat1 = new Cat();
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            animalShelter.Enqueue(cat1);
            Console.WriteLine(animalShelter.Dequeue("dog"));
        }
    }
}
