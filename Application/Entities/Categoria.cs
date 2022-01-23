﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produto = new HashSet<Produto>();
        }

        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
