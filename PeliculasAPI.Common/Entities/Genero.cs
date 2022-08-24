using PeliculasAPI.Common.Applications.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Common.Entities
{
    public class Genero : IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
        public List<PeliculasGeneros> PeliculasGeneros { get; set; }
    }
}
