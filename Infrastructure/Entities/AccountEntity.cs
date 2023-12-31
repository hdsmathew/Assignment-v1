﻿namespace Infrastructure.Entities
{
    public class AccountEntity : IEntity
    {
        public short? AccountId { get; set; } = null;
        public byte? AccountTypeId { get; set; } = null;
        public string EmailAddress { get; set; } = null;
        public string PasswordHash { get; set; } = null;
    }
}
