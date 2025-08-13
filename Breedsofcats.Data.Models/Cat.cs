using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breedsofcats.Data.Models
{
    public class Cat
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int BreedId { get; set; }

        public Breed Breed { get; set; } = null!;

        public DateTime? BirthDate { get; set; }
    }
}
