using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy14API.Domain.Models
{
    public class Skill
    {
        public virtual string ActionName { get; set; }
        public virtual int? LevelAcquired { get; set; }
        public virtual int? TpCost { get; set; }
        public virtual string MpCost { get; set; }
        public virtual string CastTime { get; set; }
        public virtual string Cooldown { get; set; }
        public virtual string Range { get; set; }
        public virtual string Radius { get; set; }
        public virtual string Description { get; set; }
    }
}
