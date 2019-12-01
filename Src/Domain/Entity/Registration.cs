using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Registration
    {
        public Registration()
        {
            Duration = new HashSet<Duration>();
            Paper = new HashSet<Paper>();
        }

        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? TestId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Toaken { get; set; }
        public DateTime? TokenExpireTime { get; set; }
        public int? AccessLevelId { get; set; }

        public virtual AccessLevels AccessLevel { get; set; }
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
        public virtual ICollection<Duration> Duration { get; set; }
        public virtual ICollection<Paper> Paper { get; set; }
    }
}
