using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class AccessLevels
    {
        public AccessLevels()
        {
            Registration = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }
    }
}
