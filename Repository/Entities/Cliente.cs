﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venda = new HashSet<Venda>();
        }

        [Key]
        public int? Codigo { get; set; }
        public string Celular { get; set; }
        public string CnpjCpf { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Venda> Venda { get; set; }
    }
}
