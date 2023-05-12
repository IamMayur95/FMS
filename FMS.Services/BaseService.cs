using System;
using FMS.Core.Common.Contracts;
using FMS.Data.Contexts;

namespace FMS.Core.Services
{
    public abstract class BaseService : IBaseService
    {
        protected readonly FMSContext DbContext;

        protected BaseService(FMSContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

    }
}

