using AutoMapper.Configuration;
using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace FMS.API.Controllers
{
    public class AccountController : BaseArgsController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;
        private readonly IConfiguration _configuration;

        public AccountController(IRequestContextService requestContextService,
        ILogger<AccountController> logger,
        IAccountService accountService, IConfiguration configuration) : base(requestContextService)
        {
            _logger = logger;
            _accountService = accountService;
            _configuration = configuration;
        }

        [HttpGet("[action]")]
        public async Task<AuthenticateUserDTO> GetUserInfo(string data, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }
            var user = await _accountService.GetUserInfoAsync(data, cancellationToken);

            return await AuthenticateAndGetUserInfo(user, cancellationToken);
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<AuthenticateUserDTO> GetUserFromTokenInfo(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();
            if (string.IsNullOrEmpty(args.EmployeeId))
            {
                return null;
            }
            var user = await _accountService.GetUserInfoByUserIdAsync(args.UserId, cancellationToken);

            return await AuthenticateAndGetUserInfo(user, cancellationToken);
        }


        private async Task<AuthenticateUserDTO> AuthenticateAndGetUserInfo(UserDTO user, CancellationToken cancellationToken)
        {
            if (user is not null)
            {

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.EmployeeId+ "|" +user.FullName+ "|" + user.Id +"|" +user.Department +"|" +user.CompanyEmailId),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return (new AuthenticateUserDTO
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    User = user,
                    TokenExpirationDateTime = token.ValidTo
                });
            }
            return new AuthenticateUserDTO();
        }

    }
}
