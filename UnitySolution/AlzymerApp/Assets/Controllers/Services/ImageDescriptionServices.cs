using Assets.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Assets.Controllers.Services
{
    public class ImageDescriptionServices
    {

        public static List<ImageDescription> GetImageList()
        {
            List<ImageDescription> lstImageDescription = new List<ImageDescription>();
            Random random = new Random();
            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Book",
            });

            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Pen",
            });
            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Gift",
            });

            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Ink Pot",
            });

            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Chair",
            });

            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Clock",
            });

            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Watch",
            });
            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Tele Vision",
            });

            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Desk",
            });

            lstImageDescription.Add(new ImageDescription
            {
                ID = random.Next(0, 100),
                ImageName = "Bottle",
            });
            return lstImageDescription.OrderBy(i => i.ID).ToList();
        }

        
    }
}
