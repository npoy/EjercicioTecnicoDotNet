using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using EjercicioTecnicoDotNet.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

namespace EjercicioTecnicoDotNet.Infrastructure.Factories
{
    /// <summary>
    /// Factory to create Rental instances.
    /// </summary>
    public class RentalFactory
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Rental creator.
        /// </summary>
        /// <param name="rentalType"></param>
        /// <param name="unity"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
        public IRental CreateInstance(string rentalType, int unity, string name, string surname)
        {
            logger.Trace("IN");

            IRental result;

            switch (rentalType)
            {
                case "RentalByHour":
                    result = new RentalByHour() { Unity = unity, Name = name, Surname = surname };
                    break;
                case "RentalByDay":
                    result = new RentalByDay() { Unity = unity, Name = name, Surname = surname };
                    break;
                case "RentalByWeek":
                    result = new RentalByWeek() { Unity = unity, Name = name, Surname = surname };
                    break;
                default:
                    result = null;
                    break;
            }

            logger.Trace("OUT > " + result);
            return result;
        }
    }
}