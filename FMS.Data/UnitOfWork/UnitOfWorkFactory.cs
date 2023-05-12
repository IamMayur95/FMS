using Microsoft.Extensions.DependencyInjection;
using System;

namespace FMS.Data.UnitOfWork
{
    internal sealed class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWorkFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IUnitOfWork GetInstance()
        {
            return _serviceProvider.GetRequiredService<IUnitOfWork>();
        }

        public IUnitOfWork GetReadonlyInstance()
        {
            var uow = GetInstance();
            uow.DisableChangeDetection();
            return uow;
        }
    }
}
