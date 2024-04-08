using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows.Models
{
    internal class Student
    {
        public long StudentID { get; set; }
        public string NameStudent { get; set; }
        public string SexStudent { get; set;}
        public string AddressStudent { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDay { get; set; }
        [StringLength(11, MinimumLength = 11), Column(TypeName = "nchar(11)")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }
        //[ForeignKey(nameof(Class))]
        public int ClassID { get; set; }
        public int BranchID { get; set; }
        //[InverseProperty("Students")]
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Class> Classes { get;}

        public Student() 
        {
            this.SubjectScoreDetails = new HashSet<SubjectScoreDetail>();
            this.Terms = new HashSet<Term>();
        }

        public virtual ICollection<SubjectScoreDetail> SubjectScoreDetails { get; set; }
        public virtual ICollection<Term> Terms { get; set; }
    }
}
