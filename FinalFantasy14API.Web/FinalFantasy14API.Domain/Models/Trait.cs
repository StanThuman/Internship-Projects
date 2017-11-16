using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy14API.Domain.Models
{
    public class Trait
    {
        public virtual string TraitName { get; set; }
        public virtual string LevelAcquired { get; set; }
        public virtual string Description { get; set; }
    }
}
