﻿using System;

namespace Core.Domain
{
    internal class EmployeeUpload
    {
        public short EmployeeId { get; set; }
        public byte Prerequisite { get; set; }
        public DateTime UploadedAt { get; set; }
        public string UploadPath { get; set; }
    }
}
