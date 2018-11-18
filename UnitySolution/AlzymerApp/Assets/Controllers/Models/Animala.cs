using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Controllers.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public int Counter { get; set; }
        public string Name {
            get
            {
                return AnimalType.ToString();
            }
        }
        public bool Correct { get; set; }
        public Animals AnimalType { get; set; }
    }

    public enum Animals
    {
        Snake = 1,
        Bear = 2,
        Dog = 3,
        Fox = 4,
        Shark = 5,
        Turtle = 6
    }
}
