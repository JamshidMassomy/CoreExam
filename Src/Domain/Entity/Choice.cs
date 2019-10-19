using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Choice
    {
        public Choice()
        {
            Paper = new HashSet<Paper>();
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Label { get; set; }
        public int? Points { get; set; }
        public bool? IsActive { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<Paper> Paper { get; set; }
    }
}
