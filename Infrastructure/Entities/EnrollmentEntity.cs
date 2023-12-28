﻿using System;

namespace Infrastructure.Entities
{
    public class EnrollmentEntity : IEntity
    {
        public int EnrollmentId { get; set; }
        public byte ApprovalStatusId { get; set; }
        public short ApproverAccountId { get; set; }
        public short EmployeeId { get; set; }
        public DateTime RequestedAt { get; set; }
        public short TrainingId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
