using Eventos.AcessoADados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.AcessoADados
{
    public class BancoDeDados : DbContext
    {

        public DbSet<Evento> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("server = localhost; " +
                "userid=root;" + "password=root;database=series;");
        }
    }
}
