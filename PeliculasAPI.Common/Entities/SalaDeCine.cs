using PeliculasAPI.Common.Applications.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PeliculasAPI.Common.Entities
{
    public class SalaDeCine : IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }
        public Point Ubicacion { get; set; }
        public List<PeliculasSalasDeCine> PeliculasSalasDeCines { get; set; }
    }
}
