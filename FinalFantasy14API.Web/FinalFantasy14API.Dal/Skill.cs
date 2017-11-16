//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalFantasy14API.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skill()
        {
            this.Class_Skills = new HashSet<Class_Skills>();
            this.Job_Skills = new HashSet<Job_Skills>();
        }
    
        public int SkillId { get; set; }
        public string ActionName { get; set; }
        public int LevelAcquired { get; set; }
        public Nullable<int> TpCost { get; set; }
        public string MpCost { get; set; }
        public string CastTime { get; set; }
        public string Cooldown { get; set; }
        public string Range { get; set; }
        public string Radius { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class_Skills> Class_Skills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Skills> Job_Skills { get; set; }
    }
}
