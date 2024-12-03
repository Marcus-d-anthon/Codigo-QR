using System;
using System.Collections.Generic;
using Codigo_QR.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Codigo_QR.Context;

public partial class CodigoQrContext : DbContext
{
    public CodigoQrContext()
    {
    }

    public CodigoQrContext(DbContextOptions<CodigoQrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CodigoQr> CodigoQrs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CompuOriginal\\SQLEXPRESS; Initial Catalog=CodigoQR; User ID=sa; Password=E46dbg; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CodigoQr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CodigoQR__3214EC270A75DFC9");

            entity.ToTable("CodigoQR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Imagen).HasColumnName("IMAGEN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
