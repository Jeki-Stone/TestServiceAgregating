using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestServiceAagregating.src
{
    /// <summary>
    /// Глобальный интерфейс сервиса коннекторов
    /// </summary>
    public interface IConector
    {
        /// <summary>
        /// Асинхронный запрос
        /// </summary>
        /// <param name="city">Город для поиска</param>
        /// <returns></returns>
        List<Car> Select(string city);
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
        bool UnBooking(Car car);
    }
}
