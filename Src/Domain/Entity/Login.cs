using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Login
    {
        public Login()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
