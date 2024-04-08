using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows.Models
{
    [PrimaryKey(nameof(TermID))]
    internal class Term
    {
        public int TermID;
        public int SubjectID { get; set; }
        public long StudentID { get; set; }
        public string NameStudent { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}
