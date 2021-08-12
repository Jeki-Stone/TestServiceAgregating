using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestServiceAgregating.src
{
    /// <summary>
    /// Глобальный интерфейс сервиса агригатора
    /// </summary>
    public interface IAgregatorService
    {
        /// <summary>
        /// Асинхронный запрос
        /// </summary>
        /// <param name="city">Город для поиска</param>
        /// <returns></returns>
        Task<List<Car>> SelectAsync(string city);
        /// <summary>
        /// Запрос на бронирование автомобиля
        /// </summary>
        /// <param name="car">Данные автомобиля</param>
        /// <returns></returns>
        bool Booking(Car car);
        /// <summary>
        /// Запрос на снятие брони с автомобиля
        /// </summary>
        /// <param name="car">Данные автомобиля</param>
        /// <returns></returns>
        bool UnBooking (Car car);        
    }
}
