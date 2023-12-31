﻿using Core.Application.Models;
using Core.Application.Repositories;
using Core.Domain;
using System;

namespace Core.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ILogger _logger;

        public AccountService(IAccountRepository accountRepository, ILogger logger)
        {
            _accountRepository = accountRepository;
            _logger = logger;
        }

        public ResponseModel<Account> Authenticate(string emailAddress, string passwordHash)
        {
            ResponseModel<Account> response = new ResponseModel<Account>();
            try
            {
                response.Entity = _accountRepository.Get(emailAddress, passwordHash);
                if (response.Entity == null)
                {
                    response.AddError(new ErrorModel()
                    {
                        Message = "Invalid EmailAddress or Password",
                    });
                    return response;
                }
            }
            catch (DALException dalEx)
            {
                _logger.LogError(dalEx, "Error in authenticating user");
                response.AddError(new ErrorModel()
                {
                    Message = "Unable to authenticate. Try again later.",
                    Exception = dalEx
                });
            }
            return response;
        }

        public ResponseModel<Account> Create(Account account)
        {
            ResponseModel<Account> response = new ResponseModel<Account>();
            try
            {
                if (_accountRepository.ExistsByEmailAddress(account.EmailAddress))
                {
                    response.AddError(new ErrorModel()
                    {
                        Message = $"Account with EmailAddress: {account.EmailAddress} already exists."
                    });
                    return response;
                }
                response.AddedRows = _accountRepository.Add(account);
                account.AccountId = _accountRepository.GetAccountIdByEmailAddress(account.EmailAddress);
                response.Entity = account;
            }
            catch (DALException dalEx)
            {
                _logger.LogError(dalEx, "Error in creating account");
                response.AddError(new ErrorModel()
                {
                    Message = "Account registration failed. Try again later.",
                    Exception = dalEx
                });
            }
            return response;
        }
    }
}
