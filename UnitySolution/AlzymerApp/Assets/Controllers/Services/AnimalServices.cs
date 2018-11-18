using Assets.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Controllers.Services
{
    public class AnimalServices
    {
        public static List<Animal> GetAnimals()
        {
            Random random = new Random();
            return new List<Animal> {
                new Animal { ID = 1, Counter = random.Next(0,100), AnimalType = Animals.Snake },
                new Animal { ID = 2, Counter = random.Next(0,100), AnimalType = Animals.Bear },
                new Animal { ID = 3, Counter = random.Next(0,100), AnimalType = Animals.Dog },
                new Animal { ID = 4, Counter = random.Next(0,100), AnimalType = Animals.Fox },
                new Animal { ID = 5, Counter = random.Next(0,100), AnimalType = Animals.Shark },
                new Animal { ID = 6, Counter = random.Next(0,100), AnimalType = Animals.Turtle }
            };
        }
    }
}
