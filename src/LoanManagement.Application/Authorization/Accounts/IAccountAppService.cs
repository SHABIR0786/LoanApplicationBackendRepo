﻿using Abp.Application.Services;
using LoanManagement.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace LoanManagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
