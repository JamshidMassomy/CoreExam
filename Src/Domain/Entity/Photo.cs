﻿using System;
using System.Collections.Generic;

namespace XM.Models.Entity
{
    public partial class Photo
    {
        public int Id { get; set; }
        public int? RecordId { get; set; }
        public string Base64 { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Path { get; set; }
        public string Descriptions { get; set; }
    }
}
