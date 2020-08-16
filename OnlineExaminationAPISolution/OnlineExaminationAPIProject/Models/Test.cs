//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineExaminationAPIProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            this.TestQuestions = new HashSet<TestQuestion>();
        }
        [DataMember]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestStructureId { get; set; }
        [DataMember]
        public Nullable<System.DateTime> StartTime { get; set; }
        [DataMember]
        public Nullable<System.DateTime> EndTime { get; set; }
        [DataMember]
        public Nullable<int> Score { get; set; }
        [DataMember]
        public Nullable<bool> Result { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestQuestion> TestQuestions { get; set; }
        public virtual TestStructure TestStructure { get; set; }
        public virtual User User { get; set; }

        public void SetProperties(int UserId, int TestStructureId)
        {
            this.UserId = UserId;
            this.TestStructureId = TestStructureId;
        }
    }
}
