using Assets.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Controllers.Services
{
    public class SerialSevenServices
    {

        public static List<SerialSevenViewModel> GetList()
        {
            var dataList =  new List<SerialSevenViewModel>();
            int j = 1;
            for (int i = 100;  i>56; i-=7)
            {
                dataList.Add(new SerialSevenViewModel
                {
                    ID = j++,
                    Correct = false,
                    Maximum = i,
                    Minimum = 7
                });
            }
            return dataList;
        }
    }
}
