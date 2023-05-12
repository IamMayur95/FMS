using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS.Core.Controllers
{
    public class WeatherForecastController : BaseController
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IWeatherForecastService weatherForecastService) 
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<WeatherForecastDTO>> Get()
        {
            return await _weatherForecastService.GetAsync();
        }
    }
}
