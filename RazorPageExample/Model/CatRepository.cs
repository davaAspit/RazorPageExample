using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageExample.Model
{
    public class CatRepository
    {
        public List<Cat> Cats { get; set; } = new List<Cat>();

        public CatRepository()
        {
            GenerateCats();
        }

        private void GenerateCats()
        {
            for (int i = 1; i < 4; i++)
            {
                Cats.Add(new Cat($"Cat{i}", $"/Images/cat{i}.jpg", "Katten kat er en kat"));
            }

        }
    }
}
