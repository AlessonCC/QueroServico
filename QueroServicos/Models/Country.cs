﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroServico.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}