﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirdShopMvcProject.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
    }
}