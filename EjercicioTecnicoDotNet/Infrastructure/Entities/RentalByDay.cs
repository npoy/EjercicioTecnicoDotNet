using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    public class RentalByDay : IRental
    {
        public RentalByDay ()
        {

        }

        public int Charging { get; set; }
    }
}