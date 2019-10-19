using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Duration
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int QuestionId { get; set; }
        public DateTime? RequestTime { get; set; }
        public DateTime? LeaveTime { get; set; }
        public DateTime? AnswredTime { get; set; }

        public virtual Question Question { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
