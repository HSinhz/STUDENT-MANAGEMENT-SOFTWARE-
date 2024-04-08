using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows.Models
{
    [PrimaryKey(nameof(SubjectScoreID))]
    internal class SubjectScoreDetail
    {
        public long SubjectScoreID;
        public int SubjectID { get; set; }
        public long StudentID { get; set; }
        public string NameStudent { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Score1 { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Score2 { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }

    }
}
