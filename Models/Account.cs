using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Windows.Models
{
    internal class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        public int RoleID { get; set; }


    }
}
