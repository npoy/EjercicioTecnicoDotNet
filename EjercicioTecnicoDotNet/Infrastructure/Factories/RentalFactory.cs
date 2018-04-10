using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using EjercicioTecnicoDotNet.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Factories
{
    public class RentalFactory
    {
        public IRental CreateInstance(string rentalType)
        {
            IRental result;

            switch (rentalType)
            {
                case "RentalByHour":
                    result = new RentalByHour();
                    break;
                case "RentalByDay":
                    result = new RentalByDay();
                    break;
                case "RentalByWeek":
                    result = new RentalByWeek();
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }
    }
}