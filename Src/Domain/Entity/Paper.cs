using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Paper
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int ChoiceId { get; set; }
        public string Answer { get; set; }
        public int? Scored { get; set; }

        public virtual Choice Choice { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
