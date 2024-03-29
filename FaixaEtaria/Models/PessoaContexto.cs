﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtaria.Models
{
    public class PessoaContexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public PessoaContexto(DbContextOptions<PessoaContexto> options) : base(options)
        {
        }
    }
}
