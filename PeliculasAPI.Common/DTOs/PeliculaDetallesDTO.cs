using System.Collections.Generic;

namespace PeliculasAPI.Common.DTOs
{
    public class PeliculaDetallesDTO : PeliculaDTO
    {
        public List<GeneroDTO> Generos { get; set; }
        public List<ActorPeliculaDetalleDTO> Actores { get; set; }
    }
}
