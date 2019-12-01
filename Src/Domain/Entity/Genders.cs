using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Genders
    {
        public Genders()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
