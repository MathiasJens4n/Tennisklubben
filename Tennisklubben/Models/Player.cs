using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tennisklubben.Models
{
    public class Player
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime RegDate { get; set; }
        public string CreditCard { get; set; }
    }
}