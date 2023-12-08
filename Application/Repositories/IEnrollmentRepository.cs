﻿using Core.Domain.Enrollment;
using System.Collections.Generic;

namespace Core.Application.Repositories
{
    public interface IEnrollmentRepository
    {
        int Add(Enrollment enrollment);
        int Delete(int enrollmentID);
        Enrollment Get(int enrollmentID);
        IEnumerable<Enrollment> GetAll();
        int Update(Enrollment enrollment);
    }
}