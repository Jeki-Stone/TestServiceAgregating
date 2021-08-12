using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestServiceAagregating.src
{
    /// <summary>
    /// Класс заглушки Dummy Taxy
    /// имитирует связь в внешней системой такси
    /// </summary>
    public class Conector2 : IConector2
    {
        /// <summary>
        /// Наименование организации коннектора
        /// </summary>
        private const string _ORGANIZATION = "Good Way";

        /// <summary>
        /// Метод заполнякет тестовыми данными коллекцию
        /// </summary>
        /// <param name="city">Город для поиска</param>
        /// <returns></returns>
        public List<Car> Select(string city)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { CarNumber="yyy1", ClienteId=0, Driver= "yyy1", Organization= _ORGANIZATION });
            cars.Add(new Car { CarNumber = "yyy2", ClienteId = 0, Driver = "yyy2", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "yyy3", ClienteId = 0, Driver = "yyy3", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "yyy4", ClienteId = 0, Driver = "yyy4", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "yyy5", ClienteId = 0, Driver = "yyy5", Organization = _ORGANIZATION });
            //8 сек ожидание
            Thread.Sleep(8000);
            return cars;
        }

        /// <summary>
        /// Запрос на бронирование автомобиля
        /// </summary>
        /// <param name="car">Данные автомобиля</param>
        /// <returns></returns>
        public bool Booking(Car car)
        {
            return true;
        }

        /// <summary>
        /// Запрос на снятие брони с автомобиля
        /// </summary>
        /// <param name="car">Данные автомобиля</param>
        /// <returns></returns>
        public bool UnBooking(Car car)
        {
            return true;
        }
    }
}
