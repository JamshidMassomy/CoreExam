using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Student
    {
        public Student()
        {
            Registration = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Nid { get; set; }
        public int? AccessLevel { get; set; }
        public DateTime? EnteryDate { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public byte[] PassHash { get; set; }
        public bool Gender { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }
    }
}
