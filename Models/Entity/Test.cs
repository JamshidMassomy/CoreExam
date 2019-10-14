using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Test
    {
        public Test()
        {
            Registration = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public int? DurationInMinutes { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }
    }
}
