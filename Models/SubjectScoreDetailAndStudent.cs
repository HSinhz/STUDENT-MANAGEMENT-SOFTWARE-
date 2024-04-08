using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows.Models
{
    internal class SubjectScoreDetailAndStudent
    {
        public long SubjectID { get; set; }
        public string SubjectName { get; set; }
        public long StudentID { get; set; }
        public string NameStudent { get; set; }
        public decimal Score1 { get; set; }
        public decimal Score2 { get; set; }
        public decimal ScoreAVR { get { return (Score1 + Score2) / 2; } }
        public string Xeploai { get; set; }

        
    }
}
