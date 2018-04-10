using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    /// <summary>
    /// Rental by hour entity.
    /// </summary>
    public class RentalByHour : IRental
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Unity { get; set; }
        public int Charging { get; set; } = 5;

        /// <summary>
        /// Method that returns the subtotal of a rental by hour.
        /// </summary>
        /// <returns></returns>
        public int GetSubTotal()
        {
            int result;
            result = Unity * Charging;
            return result;
        }
    }
}