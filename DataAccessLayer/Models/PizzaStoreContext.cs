﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class PizzaStoreContext : DbContext
{
    public PizzaStoreContext()
    {
    }

    public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Order_Detail> Order_Details { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountID).HasName("PK__Account__349DA586FA6A0288");

            entity.Property(e => e.AccountID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryID).HasName("PK__Categori__19093A2B272A733D");

            entity.Property(e => e.CategoryID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerID).HasName("PK__Customer__A4AE64B87BF6827C");

            entity.Property(e => e.CustomerID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderID).HasName("PK__Orders__C3905BAF45D64A58");

            entity.Property(e => e.OrderID).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders).HasConstraintName("FK__Orders__Customer__59063A47");
        });

        modelBuilder.Entity<Order_Detail>(entity =>
        {
            entity.HasKey(e => new { e.OrderID, e.ProductID }).HasName("PK__Order_De__08D097C177A0810B");

            entity.HasOne(d => d.Order).WithMany(p => p.Order_Details)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Order_Det__Order__5535A963");

            entity.HasOne(d => d.Product).WithMany(p => p.Order_Details)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Order_Det__Produ__5629CD9C");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductID).HasName("PK__Products__B40CC6EDEB403F9F");

            entity.Property(e => e.ProductID).ValueGeneratedNever();

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasConstraintName("FK__Products__Catego__5812160E");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products).HasConstraintName("FK__Products__Suppli__571DF1D5");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierID).HasName("PK__Supplier__4BE6669440FEFFD6");

            entity.Property(e => e.SupplierID).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}