using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasAPI.Common.DTOs
{
    public class SalaDeCineCercanoDTO : SalaDeCineDTO
    {
        public double DistanciaEnMetros { get; set; }
    }
}
