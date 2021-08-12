using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestServiceAagregating.src
{
    /// <summary>
    /// Сервис агрегации. Вызывает конекторы. 
    /// </summary>
    public class AgregatorService : IAgregatorService
    {
        private IConector1 _conector1;
        private IConector2 _conector2;
        private IConector3 _conector3;
        public AgregatorService(IConector1 conector1, IConector2 conector2, IConector3 conector3)
        {
            _conector1 = conector1;
            _conector2 = conector2;
            _conector3 = conector3;
        }

        /// <summary>
        /// Асинхронный запрос
        /// </summary>
        /// <param name="city">Город для поиска</param>
        /// <returns></returns>
        public async Task<List<Car>> SelectAsync(string city)
        {
            var сars = new List<Car>();
            var tasks = new List<Task<List<Car>>>();
            tasks.Add(Task.Run(() => _conector1.Select(city)));
            tasks.Add(Task.Run(() => _conector2.Select(city)));
            tasks.Add(Task.Run(() => _conector3.Select(city)));
            await Task.WhenAll(tasks.ToArray());
            tasks.ForEach(task => сars.AddRange(task.Result));
            return сars;
        }

        /// <summary>
        /// Запрос на бронирование автомобиля
        /// </summary>
        /// <param name="car">Данные автомобиля</param>
        /// <returns></returns>
        public bool Booking(Car car)
        {
            if (car.Organization == "Car Start")
            {
                return _conector1.Booking(car);
            }
            if (car.Organization == "Good Way")
            {
                return _conector2.Booking(car);
            };
            if (car.Organization == "Super Car")
            {
                return _conector3.Booking(car);
            }
            else 
            {
                return false;
            };
        }

        /// <summary>
        /// Запрос на снятие брони с автомобиля
        /// </summary>
        /// <param name="car">Данные автомобиля</param>
        /// <returns></returns>
        public bool UnBooking(Car car)
        {
            if (car.Organization == "Car Start")
            {
                return _conector1.UnBooking(car);
            }
            if (car.Organization == "Good Way")
            {
                return _conector2.UnBooking(car);
            };
            if (car.Organization == "Super Car")
            {
                return _conector3.UnBooking(car);
            }
            else
            {
                return false;
            };
        }
    }
}
