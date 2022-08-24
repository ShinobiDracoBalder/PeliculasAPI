using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasAPI.Common.DTOs
{
    public class GeneroCreacionDTO
    {
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
