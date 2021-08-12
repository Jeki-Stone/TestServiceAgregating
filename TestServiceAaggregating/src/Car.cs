using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestServiceAagregating.src
{
    /// <summary>
    /// Класс свойств автомобиля
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Номер автомобиля
        /// </summary>
        public string CarNumber { get; set; }
        /// <summary>
        /// Организация владеющая автомобилем
        /// </summary>
        public string Organization { get; set; }
        /// <summary>
        /// Водитель автомобиля
        /// </summary>
        public string Driver { get; set; }
        /// <summary>
        /// Id клиента забронировавшого автомобиль
        /// </summary>
        public int ClienteId { get; set; }
    }
}
