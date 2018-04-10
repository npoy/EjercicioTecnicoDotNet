using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    /// <summary>
    /// Family plan entity.
    /// </summary>
    public class FamilyPlan : IPlan
    {
        public List<IRental> Rentals { get; set; }
        public decimal Discount { get; set; } = 30;

        /// <summary>
        /// Method that returns the subtotal of a family rental.
        /// </summary>
        /// <returns></returns>
        public decimal GetSubTotal()
        {
            decimal result;
            decimal rentalsTotal = 0;

            foreach (var rental in Rentals)
            {
                int rentalCost = rental.GetSubTotal();

                rentalsTotal += rentalCost;
            }

            result = (rentalsTotal - (rentalsTotal * Discount / 100));

            return result;
        }
    }
}