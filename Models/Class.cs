using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project_Windows.Models
{
    internal class Class
    {
        public Class()
        {
            this.Branches = new HashSet<Branch>();
            this.Students = new HashSet<Student>();
        }

        public long ClassID { get; set; }
        public string NameClass { get; set; }
        //[ForeignKey(nameof(Branch))]
        public long BranchID { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
