using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurposeProject.Models
{
    public class Client
    {
        public int id { get; set; }
        Difficulty difficulty { get; set; }
        public int nivel { get; set; }
        public double points { get; set; }
        public string userId { get; set; }
        public IdentityUser user { get; set; }
    }
}
