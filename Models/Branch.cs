using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Windows.Models
{
    internal class Branch
    {
        public Branch() { 
            this.Classes = new HashSet<Class>();
            this.Students = new HashSet<Student>();
        }
        public long BranchID { get; set; }
        public string NameBranch { get; set; }

        public virtual ICollection<Class> Classes { get;set; }
        public virtual ICollection<Student> Students { get;set; }
    }
}
