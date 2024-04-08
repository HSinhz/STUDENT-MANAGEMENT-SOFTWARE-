using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows.Models
{
    [PrimaryKey(nameof(ScoreID))]
    internal class Diem
    {
        public int ScoreID;

        public long StudentID { get; set; }
        public int SubjectID { get; set; }
    }
}
