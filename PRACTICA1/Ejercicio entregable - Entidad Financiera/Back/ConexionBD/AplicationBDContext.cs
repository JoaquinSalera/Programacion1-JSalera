using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ConexionBD
{
    public class AplicationBDContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-FP7BS9I;database=EntidadFinanciera;trusted_connection=true;Encrypt=False");
        }
        public DbSet<Cliente> Clientes { get; set; } 

        public DbSet<CuentaBancaria> CuentaBancarias { get; set; }
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }
    }
}
