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
    public partial class QuestionFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionFile()
        {
            this.Questions = new HashSet<Question>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        public int LastUpdatedBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool IsCurrent { get; set; }

        public virtual Admin Admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }

        public void SetProperties(int AdminId, string FileName = "", bool IsCurrent = true)
        {
            this.Name = this.Name ?? FileName;
            this.IsCurrent = IsCurrent;
            this.LastUpdatedBy = AdminId;
            this.UpdateDate = System.DateTime.Now;
        }
    }
}
