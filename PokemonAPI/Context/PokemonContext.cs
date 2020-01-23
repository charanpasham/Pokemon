using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PokemonAPI.Models;

namespace PokemonAPI.Context
{
    public class PokemonContext : DbContext
    {
        private string _connectionString;
        public PokemonContext(IConfiguration config) : base()
        {
            _connectionString = config.GetConnectionString("PokemonSql");
        }

        public DbSet<Pokemon> Pokemon { get; set; }

        /// <summary>
        /// Database setup
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"{_connectionString};Database=PokemonDb;");
        }
    }
}
