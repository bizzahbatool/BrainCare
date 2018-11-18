using Assets.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
namespace Assets.Controllers.Services
{
    public class MemoryTrainServices
    {
        public static List<MemoryTrainViewModel> GetShapes()
        {
            List<MemoryTrainViewModel> memoryTrain = new List<MemoryTrainViewModel>();
            memoryTrain.Add(new MemoryTrainViewModel
            {
                 Color = Colors.Blue , Name = "Circle", Shape = Shapes.Circle
            });
            memoryTrain.Add(new MemoryTrainViewModel
            {
                 Color = Colors.Red , Name = "Square", Shape = Shapes.Square
            });
            memoryTrain.Add(new MemoryTrainViewModel
            {
                 Shape = Shapes.Triangle , Name = "Triangle", Color = Colors.Yellow
            });
            memoryTrain.Add(new MemoryTrainViewModel
            {
                 Name = "Star", Shape = Shapes.Star, Color = Colors.Green
            });
            memoryTrain.AddRange(memoryTrain);
            memoryTrain.AddRange(memoryTrain);
            return memoryTrain.ToList();
        }

        public static MemoryTrainDataEntity Validate(MemoryTrainViewModel model, bool typeOfQuestion,Shapes Selectedshapes , Colors Selectedcolors)
        {
            MemoryTrainDataEntity entity;
            if (typeOfQuestion) // true Check shapes
            {
                entity = new MemoryTrainDataEntity { ID = model.ID, Color = model.Color, Shape = model.Shape, Name = model.Name };
                entity.Guessed = model.Shape == Selectedshapes ? true : false;
            }
            else
            {
                entity = new MemoryTrainDataEntity { ID = model.ID, Color = model.Color, Shape = model.Shape, Name = model.Name };
                entity.Guessed = model.Color == Selectedcolors ? true : false;

            }
            return entity;
        }
    }
}
