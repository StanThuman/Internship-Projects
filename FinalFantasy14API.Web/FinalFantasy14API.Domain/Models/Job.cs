using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy14API.Domain.Models
{
    public class Job
    {
        public virtual string JobName { get; set; }
        public virtual string WeaponType { get; set; }
        public virtual string Role { get; set; }        
        public virtual string MainClass { get; set; }
        public virtual string SubClass{ get; set; }
        
    }
}
