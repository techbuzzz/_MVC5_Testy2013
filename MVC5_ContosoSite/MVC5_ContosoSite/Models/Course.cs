//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5_ContosoSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Course
    {
        public Course()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }
    
        public int CourseID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public Nullable<int> Credits { get; set; }
    
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}