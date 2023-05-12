using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Utils.Data.Interfaces
{
    //Made for better identification for service providers
    public interface IDbInitializer<T> : IDbInitializer
        where T : DbContext
	{
        public bool IsDbExistant { get; }
    }

    public interface IDbInitializer
    {
        Task MigrateAndSeedIfNeededAsync();
    }
}
