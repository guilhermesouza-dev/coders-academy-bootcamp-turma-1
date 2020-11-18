﻿using CodersAcademy.API.Model;
using CodersAcademy.API.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CodersAcademy.API.Repository
{
    public class MusicContext : DbContext
    {

        public DbSet<Album> Albuns { get; set; }
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AbumMapping());
            modelBuilder.ApplyConfiguration(new MusicMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
