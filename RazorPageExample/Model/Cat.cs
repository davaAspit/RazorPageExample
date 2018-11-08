using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageExample.Model
{
    public class Cat
    {
        public Cat(string name, string imageUrl, string description)
        {
            Name = name;
            ImageUrl = imageUrl;
            Description = description;
        }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
