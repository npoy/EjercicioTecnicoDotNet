using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTecnicoDotNet.Infrastructure.Contracts
{
    public interface IRental
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Unity { get; set; }
        int Charging { get; set; }

        int GetSubTotal();
    }
}
