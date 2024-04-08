using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project_Windows.Models
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int SubjectCredit { get; set; }


        public Subject() 
        { 
            this.SubjectScoreDetails = new HashSet<SubjectScoreDetail>();
            this.Terms = new HashSet<Term>();
        }
        public virtual ICollection<SubjectScoreDetail> SubjectScoreDetails { get; set; }
        public virtual ICollection<Term> Terms { get; set; }
    }
}
