using AutoMapper;
using FMS.Contracts;
using FMS.Core.Services;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Services.Services
{
    public class WeatherForecastService : BaseAuditableService, IWeatherForecastService
    {
        private readonly IMapper _mapper;
        public WeatherForecastService(
            IUnitOfWorkFactory unitOfWorkFactory,
            IMapper mapper) : base(unitOfWorkFactory)
        {
            _mapper = mapper;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public async Task<IEnumerable<WeatherForecastDTO>> GetAsync()
        {
            var rng = new Random();
            return await Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecastDTO
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray());
        }
    }
}
