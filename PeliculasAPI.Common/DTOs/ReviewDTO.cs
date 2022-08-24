using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasAPI.Common.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public int Puntuacion { get; set; }
        public int PeliculaId { get; set; }
        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
    }
}
