using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_12
{
    public class AnimalShelter
    {
        public Queue<Cat> Cats = new();
        public Queue<Dog> Dogs = new();

        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                Cats.Enqueue(new Cat());
            }
            else if (animal is Dog)
            {
                Dogs.Enqueue(new Dog());
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            {
                return Cats.Dequeue();
            }
            else if (pref == "dog")
            {
                return Dogs.Dequeue();
            }
            else
            {
                return null;
            }
        }
    }

}
