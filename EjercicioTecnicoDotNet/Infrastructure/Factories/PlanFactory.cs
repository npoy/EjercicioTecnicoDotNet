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
    /// Factory to create Plan instances.
    /// </summary>
    public class PlanFactory
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Plan creator.
        /// </summary>
        /// <param name="planType"></param>
        /// <param name="unity"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
        public IPlan CreateInstance(List<IRental> rentals)
        {
            logger.Trace("IN");

            IPlan result;
            int unity = rentals.Count();

            string planType = "";

            if (unity >= 3 && unity <= 5)
            {
                planType = "Family";
            }
            else if (unity > 0 && unity < 3)
            {
                planType = "Individual";
            }

            switch (planType)
            {
                case "Individual":
                    result = new IndividualPlan() { Rentals = rentals };
                    break;
                case "Family":
                    result = new FamilyPlan() { Rentals = rentals };
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