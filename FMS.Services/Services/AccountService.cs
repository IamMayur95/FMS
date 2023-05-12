using AutoMapper;
using FMS.Contracts;
using FMS.Core.Common.Contracts.Configuration;
using FMS.Core.Services;
using FMS.Data.Contexts;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using FMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Services.Services
{
    public class AccountService : BaseAuditableService, IAccountService
    {
        private readonly IMapper _mapper;
        private readonly FMSContext _context;

        private readonly ApplicationSettings _applicationSettings;
        public AccountService(IUnitOfWorkFactory unitOfWorkFactory, FMSContext context, ApplicationSettings applicationSettings,
                        IMapper mapper) : base(unitOfWorkFactory)
        {
            _context = context;
            _mapper = mapper;
            _applicationSettings = applicationSettings;
        }

        public async Task<UserDTO> GetUserInfoAsync(string data, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(data))
                return null;

            var decryptedText = DecryptData(data, 666666);

            var retVal = new UserDTO();

            if (!string.IsNullOrEmpty(decryptedText))
            {
                var userData = JsonConvert.DeserializeObject<DecryptedUserDTO>(decryptedText);
                using var unitOfWork = UnitOfWorkFactory.GetReadonlyInstance();
                var userRepository = unitOfWork.CreateRepository<User>(true);

                retVal = _mapper.Map<UserDTO>(await userRepository.Query().Where(item => item.EmployeeId == userData.Employee_no && item.CompanyEmailId == userData.Email).FirstOrDefaultAsync(cancellationToken));

            }

            return retVal;
        }


        public async Task<UserDTO> GetUserInfoByUserIdAsync(int userId, CancellationToken cancellationToken)
        {
            if (userId <= 0)
                return null;

            var retVal = new UserDTO();

            using var unitOfWork = UnitOfWorkFactory.GetReadonlyInstance();
            var userRepository = unitOfWork.CreateRepository<User>(true);

            retVal = _mapper.Map<UserDTO>(await userRepository.Query().Where(item => item.Id == userId).FirstOrDefaultAsync(cancellationToken));
            return retVal;
        }

        private string DecodeBase64(string value)
        {
            var valueBytes = System.Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }

        private string DecryptData(string szPlainText, int szEncryptionKey)
        {
            var decoded = System.Convert.FromBase64String(szPlainText);

            byte[] result = new byte[decoded.Length];

            for (int c = 0; c < decoded.Length; c++)
            {
                result[c] = (byte)((uint)decoded[c] ^ (uint)szEncryptionKey.ToString()[c % szEncryptionKey.ToString().Length]);
            }

            string dexored = Encoding.UTF8.GetString(result);

            return DecodeBase64(dexored);

            //StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            //StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            //char Textch;
            //for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            //{
            //    Textch = szInputStringBuild[iCount];
            //    Textch = (char)(Textch ^ szEncryptionKey);
            //    szOutStringBuild.Append(Textch);
            //}
            //return szOutStringBuild.ToString();
        }
    }
}