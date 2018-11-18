using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Controllers.Models
{
    public class MemoryTrainViewModel
    {
        public double ID { get; set; }
        public string Name { get; set; }
        public Colors Color { get; set; }
        public Shapes Shape { get; set; }
    }
    public class MemoryTrainDataEntity : MemoryTrainViewModel
    {
        public bool Guessed { get; set; }
    }
    public enum Colors
    {
        Yellow ,
        Blue,
        Red ,
        Green
    }
    public enum Shapes
    {
        Circle,
        Square,
        Triangle,
        Star
    }
}
