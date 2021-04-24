﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_EFCore.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(200)")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        public int Dorsal { get; set; }

    }
}
