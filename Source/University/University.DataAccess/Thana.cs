//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Thana
    {
        public Thana()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int DistrictId { get; set; }
    
        public virtual District District { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
