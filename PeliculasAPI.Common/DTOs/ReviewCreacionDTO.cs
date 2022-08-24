using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasAPI.Common.DTOs
{
    public class ReviewCreacionDTO
    {
        public string Comentario { get; set; }
        [Range(1, 5)]
        public int Puntuacion { get; set; }
    }
}
