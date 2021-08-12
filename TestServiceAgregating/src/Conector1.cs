using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestServiceAgregating.src
{
    /// <summary>
    /// Класс заглушки Dummy Taxy
    /// имитирует связь в внешней системой такси
    /// </summary>
    public class Conector1 : IConector1
    {
        /// <summary>
        /// Наименование организации коннектора
        /// </summary>
        private const string _ORGANIZATION = "Car Start";

        /// <summary>
        /// Метод заполнякет тестовыми данными коллекцию
        /// </summary>
        /// <param name="city">Город для поиска</param>
        /// <returns></returns>
        public List<Car> Select(string city)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { CarNumber="xxx1", ClienteId=0, Driver="xxx1", Organization= _ORGANIZATION });
            cars.Add(new Car { CarNumber = "xxx2", ClienteId = 0, Driver = "xxx2", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "xxx3", ClienteId = 0, Driver = "xxx3", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "xxx4", ClienteId = 0, Driver = "xxx4", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "xxx5", ClienteId = 0, Driver = "xxx5", Organization = _ORGANIZATION });
            //5 сек ожидание
            Thread.Sleep(5000);
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
