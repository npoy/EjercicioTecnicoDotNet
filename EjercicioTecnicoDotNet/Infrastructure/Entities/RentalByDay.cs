using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    /// <summary>
    /// Rental by day entity.
    /// </summary>
    public class RentalByDay : IRental
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Unity { get; set; }
        public int Charging { get; set; } = 20;

        /// <summary>
        /// Method that returns the subtotal of a rental by day.
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