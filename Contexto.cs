using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using CasaDoCodigo.Models;


namespace CasaDoCodigo
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

    }
}