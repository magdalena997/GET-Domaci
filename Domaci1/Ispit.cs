//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domaci1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ispit
    {
        public int IdI { get; set; }
        public Nullable<int> BrIndeksa { get; set; }
        public Nullable<int> IdP { get; set; }
        public Nullable<int> Ocena { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
    
        public virtual Predmet Predmet { get; set; }
        public virtual Student Student { get; set; }
    }
}
