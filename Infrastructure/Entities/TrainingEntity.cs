﻿using System;

namespace Infrastructure.Entities
{
    public class TrainingEntity : IEntity
    {
        public short? TrainingId { get; set; } = null;
        public byte? PreferredDepartmentId { get; set; } = null;
        public DateTime RegistrationDeadline { get; set; }
        public short? SeatsAvailable { get; set; } = null;
        public string TrainingDescription { get; set; } = null;
        public string TrainingName { get; set; } = null;
    }
}
