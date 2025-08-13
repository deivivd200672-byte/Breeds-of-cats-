using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breedsofcats.Data.Models
{
    public class UserCatFavorite
    {
        public string UserId { get; set; } = null!;

        //public ApplicationUser User { get; set; }

        public int BreedId { get; set; }

        public virtual Breed Breed { get; set; } = null!;
    }
}
