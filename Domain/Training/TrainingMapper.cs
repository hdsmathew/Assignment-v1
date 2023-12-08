﻿using Core.Domain.Common;
using System;
using System.Collections.Generic;

namespace Core.Domain.Training
{
    public class TrainingMapper : MapperBase<Training>
    {
        public override Training MapRowToObject(Dictionary<string, object> row)
        {
            Training training = new Training()
            {
                ID = Convert.ToInt32(row["ID"]),
                Name = row["name"].ToString(),
                PreferredDeptID = Convert.ToInt32(row["preferredDeptID"]),
                SeatsAvailable = Convert.ToInt32(row["seatsAvailable"]),
                RegistrationDeadline = Convert.ToDateTime(row["registrationDeadline"])
            };
            return training;
        }
    }
}