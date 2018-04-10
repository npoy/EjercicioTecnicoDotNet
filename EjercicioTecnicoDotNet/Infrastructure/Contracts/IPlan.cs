using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTecnicoDotNet.Infrastructure.Contracts
{
    /// <summary>
    /// Plan contract.
    /// </summary>
    public interface IPlan
    {
        List<IRental> Rentals { get; set; }
        decimal Discount { get; set; }
        decimal GetSubTotal();
    }
}
