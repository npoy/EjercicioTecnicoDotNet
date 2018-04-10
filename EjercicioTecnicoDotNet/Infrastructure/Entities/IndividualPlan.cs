using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    /// <summary>
    /// Individual plan.
    /// </summary>
    public class IndividualPlan : IPlan
    {
        public decimal Discount
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<IRental> Rentals { get; set; }

        public decimal GetSubTotal()
        {
            throw new NotImplementedException();
        }
    }
}