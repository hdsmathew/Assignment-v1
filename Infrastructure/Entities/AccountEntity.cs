﻿namespace Infrastructure.Entities
{
    public class AccountEntity : EntityBase
    {
        public ushort AccountId { get; set; }
        public byte AccountTypeId { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
    }
}