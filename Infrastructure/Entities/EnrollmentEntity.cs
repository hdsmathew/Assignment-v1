﻿using System;

namespace Infrastructure.Entities
{
    public class EnrollmentEntity : IEntity
    {
        public int? EnrollmentId { get; set; } = null;
        public byte ApprovalStatusId { get; set; }
        public short? ApproverAccountId { get; set; } = null;
        public short? EmployeeId { get; set; } = null;
        public DateTime RequestedAt { get; set; }
        public short? TrainingId { get; set; } = null;
        public DateTime UpdatedAt { get; set; }
    }
}
