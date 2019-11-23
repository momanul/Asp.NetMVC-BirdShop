using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirdShopMvcProject.Models
{
    public class Dealers
    {
        public int Id { get; set; }
        public string DealerName { get; set; }
        public string City { get; set; }
        public virtual ICollection<Birds> Birds { get; set; }
    }
}