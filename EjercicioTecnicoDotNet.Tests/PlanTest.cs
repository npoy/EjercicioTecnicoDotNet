using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioTecnicoDotNet.Infrastructure.Factories;
using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System.Collections.Generic;

namespace EjercicioTecnicoDotNet.Tests
{
    [TestClass]
    public class PlanTest
    {
        /// <summary>
        /// TestMethod to check if PlanFactory is creating correctly Individual instances.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void PlanFactory_CreateInstance_IndividualPlan_NotNull_Test_Unit()
        {
            RentalFactory rentalFactory = new RentalFactory();
            List<IRental> rentals = new List<IRental>();
            rentals.Add(rentalFactory.CreateInstance("RentalByHour", 8, "Charly", "Garcia"));

            PlanFactory planFactory = new PlanFactory();
            IPlan plan = planFactory.CreateInstance(rentals);

            Assert.IsNotNull(plan);
        }

        /// <summary>
        /// TestMethod to check if PlanFactory is creating correctly Family instances.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void PlanFactory_CreateInstance_FamilyPlan_NotNull_Test_Unit()
        {
            RentalFactory rentalFactory = new RentalFactory();
            List<IRental> rentals = new List<IRental>();
            rentals.Add(rentalFactory.CreateInstance("RentalByHour", 8, "Charly", "Garcia"));
            rentals.Add(rentalFactory.CreateInstance("RentalByDay", 2, "Pepe", "Argento"));
            rentals.Add(rentalFactory.CreateInstance("RentalByWeek", 1, "Martha", "Sanchez"));

            PlanFactory planFactory = new PlanFactory();
            IPlan plan = planFactory.CreateInstance(rentals);

            Assert.IsNotNull(plan);
        }

        /// <summary>
        /// TestMethod to check if PlanFactory.GetSubTotal() of a individual plan is getting the correct exception.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void PlanFactory_CreateInstance_IndividualPlan_OK_Test_Unit()
        {
            bool result = false;
            decimal subTotal;

            try
            {
                RentalFactory rentalFactory = new RentalFactory();
                List<IRental> rentals = new List<IRental>();
                rentals.Add(rentalFactory.CreateInstance("RentalByHour", 8, "Charly", "Garcia"));

                PlanFactory planFactory = new PlanFactory();
                IPlan plan = planFactory.CreateInstance(rentals);
                subTotal = plan.GetSubTotal();

                if (subTotal == 98)
                    result = true;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is NotImplementedException);
            }
        }

        /// <summary>
        /// TestMethod to check if PlanFactory.GetSubTotal() is getting correctly Family value.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void PlanFactory_CreateInstance_FamilyPlan_OK_Test_Unit()
        {
            bool result = false;
            decimal subTotal;

            RentalFactory rentalFactory = new RentalFactory();
            List<IRental> rentals = new List<IRental>();
            rentals.Add(rentalFactory.CreateInstance("RentalByHour", 8, "Charly", "Garcia"));
            rentals.Add(rentalFactory.CreateInstance("RentalByDay", 2, "Pepe", "Argento"));
            rentals.Add(rentalFactory.CreateInstance("RentalByWeek", 1, "Martha", "Sanchez"));

            PlanFactory planFactory = new PlanFactory();
            IPlan plan = planFactory.CreateInstance(rentals);
            subTotal = plan.GetSubTotal();

            if (subTotal == 98)
                result = true;

            Assert.IsTrue(result);
        }
    }
}