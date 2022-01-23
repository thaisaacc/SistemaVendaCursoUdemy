﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public partial class Venda
    {
        public Venda()
        {
            Vendaproduto = new HashSet<Vendaproduto>();
        }

        [Key]
        public int Codigo { get; set; }
        public int? Codcliente { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; }
        public virtual ICollection<Vendaproduto> Vendaproduto { get; set; }
    }
}
