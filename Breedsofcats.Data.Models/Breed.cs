using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Breedsofcats.Data.Models
{
    public class Breed
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? CoverImageUrl { get; set; }

        public string PublisherId { get; set; } = null!;

        //public virtual IdentityUser Publisher { get; set; } = null!;

        public DateTime PublishedOn { get; set; }

        public int OriginId { get; set; }

        public virtual Origin Origin { get; set; } = null!;

        //public bool IsDeleted { get; set; };
    }
}
