using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioTecnicoDotNet.Infrastructure.Factories;
using EjercicioTecnicoDotNet.Infrastructure.Contracts;

namespace EjercicioTecnicoDotNet.Tests
{
    [TestClass]
    public class RentalTest
    {
        /// <summary>
        /// TestMethod to check if RentalFactory is creating correctly ByHour instances.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void RentalFactory_CreateInstance_RentalByHour_NotNull_Test_Unit()
        {
            int unity = 8;

            RentalFactory rentalFactory = new RentalFactory();
            IRental rental = rentalFactory.CreateInstance("RentalByHour", unity, "Charly", "Tevez");

            Assert.IsNotNull(rental);
        }

        /// <summary>
        /// TestMethod to check if RentalFactory is creating correctly ByDay instances.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void RentalFactory_CreateInstance_RentalByDay_NotNull_Test_Unit()
        {
            int unity = 3;

            RentalFactory rentalFactory = new RentalFactory();
            IRental rental = rentalFactory.CreateInstance("RentalByDay", unity, "Willy", "Wonka");

            Assert.IsNotNull(rental);
        }

        /// <summary>
        /// TestMethod to check if RentalFactory is creating correctly ByWeek instances.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void RentalFactory_CreateInstance_RentalByWeek_NotNull_Test_Unit()
        {
            int unity = 1;

            RentalFactory rentalFactory = new RentalFactory();
            IRental rental = rentalFactory.CreateInstance("RentalByWeek", unity, "James", "Rodriguez");

            Assert.IsNotNull(rental);
        }

        /// <summary>
        /// TestMethod to check if RentalFactory.GetSubTotal() is getting correctly ByHour value.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void RentalFactory_CreateInstance_RentalByHour_OK_Test_Unit()
        {
            bool result = false;

            int unity = 8;
            int subTotal;

            RentalFactory rentalFactory = new RentalFactory();
            IRental rental = rentalFactory.CreateInstance("RentalByHour", unity, "Charly", "Tevez");
            subTotal = rental.GetSubTotal();

            if (subTotal == 40)
                result = true;

            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestMethod to check if RentalFactory.GetSubTotal() is getting correctly ByWeek value.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void RentalFactory_CreateInstance_RentalByDay_OK_Test_Unit()
        {
            bool result = false;

            int unity = 3;
            int subTotal;

            RentalFactory rentalFactory = new RentalFactory();
            IRental rental = rentalFactory.CreateInstance("RentalByDay", unity, "Willy", "Wonka");
            subTotal = rental.GetSubTotal();

            if (subTotal == 60)
                result = true;

            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestMethod to check if RentalFactory.GetSubTotal() is getting correctly ByWeek value.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void RentalFactory_CreateInstance_RentalByWeek_OK_Test_Unit()
        {
            bool result = false;

            int unity = 1;
            int subTotal;

            RentalFactory rentalFactory = new RentalFactory();

            IRental rental = rentalFactory.CreateInstance("RentalByWeek", unity, "James", "Rodriguez");
            subTotal = rental.GetSubTotal();

            if (subTotal == 60)
                result = true;

            Assert.IsTrue(result);
        }
    }
}
