﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empleado
    {
        [Key]

        [Required]
        public int PkEmpleado { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        public string Dirreccion { get; set; }
        public string Ciudad { get; set; }


        [ForeignKey("Puesto")]
        public int? FkPuesto{ get; set; }

        [ForeignKey("Departamento")]
        public int? FkDepartamento { get; set; }

        public Puesto Puesto { get; set; }
        public Departamento Departamento { get; set; }


    }
}
