using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? GenderId { get; set; }
        public int? RoleId { get; set; }
        public int? LoginId { get; set; }

        public virtual Genders Gender { get; set; }
        public virtual Login Login { get; set; }
        public virtual Roles Role { get; set; }
    }
}
