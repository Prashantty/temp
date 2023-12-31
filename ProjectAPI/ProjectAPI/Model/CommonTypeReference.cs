﻿using MessagePack;
using System.Reflection.Metadata.Ecma335;

namespace ProjectAPI.Model
{
    public class CommonTypeReference
    {
        
        public int Id { get; set; }

        public int Value { get; set; }

        public string Type { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Boolean IsActive { get; set; } = true;


    }
}
