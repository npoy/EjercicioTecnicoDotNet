using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    /// <summary>
    /// Rental by week entity.
    /// </summary>
    public class RentalByWeek : IRental
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Unity { get; set; }
        public int Charging { get; set; } = 60;

        /// <summary>
        /// Method that returns the subtotal of a rental by week.
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