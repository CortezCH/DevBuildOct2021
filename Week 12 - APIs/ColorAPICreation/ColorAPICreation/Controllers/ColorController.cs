﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorAPICreation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase
    {
        //What we will do tomorrow is pull in models from our database 
        public List<string> Colors = new List<string>() {"red","blue","green","black","white","grey" };

        [HttpGet]
        public List<string> GetAllColors()
        {
            return Colors;
        }

        [HttpGet("GreyTones")]
        public List<string> GetGreyTones()
        {
            return Colors.GetRange(3, 3);
        }

        //When you see {} that means the value is a parameter the user can feed in
        [HttpGet("GetColor/{index}")]
        public string GetColorByIndex(int index)
        {
            try
            {
                return Colors[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                return $"{index} was not a valid color Id, please input a number between 0 and {Colors.Count - 1}";
            }
        }
    }
}
