﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteczka.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
    }
}
