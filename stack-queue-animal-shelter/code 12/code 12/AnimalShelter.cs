using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_12
{
    public class AnimalShelter
    {
        public Queue<Dog> Dogs { get; set; }
        public Queue<Cat> Cats { get; set; }

        public AnimalShelter()
        {
            Dogs = new Queue<Dog>();
            Cats = new Queue<Cat>();
        }

        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                Cat cat = (Cat)animal;
                Cats.Enqueue(cat);
            }
            else if (animal is Dog)
            {
               
            }
        }
        /*public Animal Dequeue(string pref)
        {
            
        }*/
    }
}
