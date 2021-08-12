using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestServiceAgregating.src;

namespace TestServiceAgregating.Controllers
{
    /// <summary>
    /// Агрегатор такси
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AgregatorTaxiController : ControllerBase
    {
       
        private readonly ILogger<AgregatorTaxiController> _logger;
        private readonly IAgregatorService _service;

        public AgregatorTaxiController(ILogger<AgregatorTaxiController> logger, IAgregatorService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Список предложений
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Car>> Get(string city)
        {
            return await _service.SelectAsync(city);
        }

        /// <summary>
        /// Забронировать такси
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPost]
        public bool Booking(Car car)
        {
            return _service.Booking(car);
        }

        /// <summary>
        /// Снять бронь
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPut]
        public bool UnBooking(Car car)
        {
            return _service.UnBooking(car);
        }
    }
}
