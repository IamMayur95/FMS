using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IWeatherForecastService : IBaseService
    {
        Task<IEnumerable<WeatherForecastDTO>> GetAsync();
    }
}
