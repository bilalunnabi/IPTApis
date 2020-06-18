//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IptApis.Models.PointRegistration.PointDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assignment()
        {
            this.StudentAssignments = new HashSet<StudentAssignment>();
        }
    
        public int AssignmentID { get; set; }
        public string AssignmentName { get; set; }
        public string AttachmentLink { get; set; }
        public System.DateTime DueDateTime { get; set; }
        public string ReSubmissionAllowed { get; set; }
        public int FSID { get; set; }
    
        public virtual FacultySection FacultySection { get; set; }
        public virtual FacultySection FacultySection1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }
    }
}
