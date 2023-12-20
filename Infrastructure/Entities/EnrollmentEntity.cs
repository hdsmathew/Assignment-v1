﻿using System;

namespace Infrastructure.Entities
{
    public class EnrollmentEntity : EntityBase
    {
        public uint EnrollmentId { get; set; }
        public byte ApprovalStatusId { get; set; }
        public ushort ApproverAccountId { get; set; }
        public ushort EmployeeId { get; set; }
        public DateTime RequestedAt { get; set; }
        public ushort TrainingId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
