using BirdShopMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirdShopMvcProject.ViewModels
{
    public class BirdsVM
    {
        
        public string BirdName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }

        public Dealers Dealers { get; set; }


    }
}