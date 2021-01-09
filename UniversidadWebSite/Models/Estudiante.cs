using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Text.Json.Serialization;

namespace UniversidadWebSite.Models
{
    [Table("Estudiantes")]
    public class Estudiante
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Semestre { get; set; }

        public string Foto { get; set; }
    }
}