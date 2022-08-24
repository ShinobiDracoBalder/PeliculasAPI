﻿using PeliculasAPI.Common.Applications.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace PeliculasAPI.Common.Entities
{
    public class Actor : IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Foto { get; set; }
        public List<PeliculasActores> PeliculasActores { get; set; }
    }
}