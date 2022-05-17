﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessForBusiness.Core.Models
{
    class User
    {
        public int Id { get; set;}

        public string Name { get; set; }

        public string Surname { get; set;}

        public string ImageSource { get; set; }

        public DateTime Age { get; set;}

        public bool? Level { get; set;}

        public bool? Goal { get; set;}

        public string Login { get; set; }

        public string Password { get; set; }
    }
}