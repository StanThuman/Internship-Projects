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
    
    public partial class Class_Traits
    {
        public int Class_TraitsId { get; set; }
        public int FFClassId { get; set; }
        public int TraitId { get; set; }
    
        public virtual FFClass FFClass { get; set; }
        public virtual Trait Trait { get; set; }
    }
}
