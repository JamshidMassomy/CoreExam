﻿using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Category
    {
        public Category()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
