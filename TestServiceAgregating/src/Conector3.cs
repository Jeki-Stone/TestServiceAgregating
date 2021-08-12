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
    public class Conector3 : IConector3
    {
        /// <summary>
        /// Наименование организации коннектора
        /// </summary>
        private const string _ORGANIZATION = "Super Car";

        /// <summary>
        /// Метод заполнякет тестовыми данными коллекцию
        /// </summary>
        /// <param name="city">Город для поиска</param>
        /// <returns></returns>
        public List<Car> Select(string city)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { CarNumber="ttt1", ClienteId=0, Driver= "ttt1", Organization= _ORGANIZATION });
            cars.Add(new Car { CarNumber = "ttt2", ClienteId = 0, Driver = "ttt2", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "ttt3", ClienteId = 0, Driver = "ttt3", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "ttt4", ClienteId = 0, Driver = "ttt4", Organization = _ORGANIZATION });
            cars.Add(new Car { CarNumber = "ttt5", ClienteId = 0, Driver = "ttt5", Organization = _ORGANIZATION });
            //3 сек ожидание
            Thread.Sleep(3000);
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
