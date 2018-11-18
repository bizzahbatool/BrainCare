using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Controllers.Models
{
    public class ImageDescription
    {
        public int ID { get; set; }
        public string ImageName { get; set; }
        public bool Guessed { get; set; }
    }
}
