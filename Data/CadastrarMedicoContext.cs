using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastrarMedico.Models;

namespace CadastrarMedico.Data
{
    public class CadastrarMedicoContext : DbContext
    {
        public CadastrarMedicoContext (DbContextOptions<CadastrarMedicoContext> options)
            : base(options)
        {
        }

        public DbSet<CadastrarMedico.Models.Medicos> Medicos { get; set; }
    }
}
