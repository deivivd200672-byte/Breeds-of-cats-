using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breedsofcats.Data.Models
{
    public class Origin
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Breed> Breeds { get; set; }
            = new HashSet<Breed>();
    }
}
