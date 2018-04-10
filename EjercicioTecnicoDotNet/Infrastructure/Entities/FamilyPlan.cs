using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    public class FamilyPlan : IPlan
    {
        public List<IRental> Rentals { get; set; }
        public decimal Discount { get; set; } = 30;
        public decimal GetSubTotal()
        {
            decimal result;
            int rentalsTotal = 0;

            foreach (var rental in Rentals)
            {
                int rentalCost = (rental.Unity * rental.Charging);

                rentalsTotal += rentalCost;
            }

            result = (rentalsTotal - (rentalsTotal * Discount / 100));

            return result;
        }
    }
}