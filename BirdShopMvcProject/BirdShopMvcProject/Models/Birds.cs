using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirdShopMvcProject.Models
{
    public class Birds
    {
        public int Id { get; set; }
        public string BirdName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }
        public int DealersID { get; set; }

        public virtual Dealers Dealers { get; set; }
    }
}