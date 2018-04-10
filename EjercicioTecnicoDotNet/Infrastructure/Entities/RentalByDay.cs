using EjercicioTecnicoDotNet.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioTecnicoDotNet.Infrastructure.Entities
{
    public class RentalByDay : IRental
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Unity { get; set; }
        public int Charging { get; set; } = 20;

        public int GetSubTotal()
        {
            int result;
            result = Unity * Charging;
            return result;
        }
    }
}