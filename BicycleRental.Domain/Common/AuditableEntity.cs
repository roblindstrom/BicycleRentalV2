﻿using System;

namespace BicycleRental.Domain.Common
{
    public class AuditableEntity
    {
        
        public DateTime CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}
