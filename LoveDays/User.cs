using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveDays
{
    internal class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string date_of_birth { get; set; }
        public User lover { get; set; }
    }
}
