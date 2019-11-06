using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Question
    {
        public Question()
        {
            Choice = new HashSet<Choice>();
            Duration = new HashSet<Duration>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int QuestionTypeId { get; set; }
        public string Lebel { get; set; }
        public int? Point { get; set; }
        public bool? IsActive { get; set; }

        public virtual Category Category { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual ICollection<Choice> Choice { get; set; }
        public virtual ICollection<Duration> Duration { get; set; }
    }
}
