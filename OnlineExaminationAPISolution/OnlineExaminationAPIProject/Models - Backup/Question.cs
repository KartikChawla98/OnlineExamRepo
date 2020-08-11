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
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.TestQuestions = new HashSet<TestQuestion>();
        }
    
        public int Id { get; set; }
        public int FileId { get; set; }
        public string Technology { get; set; }
        public int Level { get; set; }
        public string QuestionString { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public int CorrectOption { get; set; }
    
        public virtual QuestionFile QuestionFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestQuestion> TestQuestions { get; set; }

        public bool SetProperties(int FileId, CSVQuestion temp)
        {
            try
            {
                this.FileId = FileId;
                this.Technology = temp[0];
                int value = 0;
                int.TryParse(temp[1], out value);
                if (value < 1 || value > 3)
                    return false;
                this.Level = value;
                this.QuestionString = temp[2];
                this.Option1 = temp[3];
                this.Option2 = temp[4];
                this.Option3 = temp[5];
                this.Option4 = temp[6];
                value = 0;
                int.TryParse(temp[7], out value);
                if (value < 1 || value > 4)
                    return false;
                this.CorrectOption = value;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
