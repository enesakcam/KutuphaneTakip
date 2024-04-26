﻿// <auto-generated />
using KutuphaneTakip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KutuphaneTakip.Migrations
{
    [DbContext(typeof(KutuphaneDbContext))]
    [Migration("20240426065813_mssql_migration_759")]
    partial class mssql_migration_759
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KutuphaneTakip.Models.Adres", b =>
                {
                    b.Property<int>("AdresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresId"), 1L, 1);

                    b.Property<string>("OgrenciAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("AdresId");

                    b.HasIndex("OgrenciId")
                        .IsUnique();

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("KutuphaneTakip.Models.Kitap", b =>
                {
                    b.Property<int>("KitapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapId"), 1L, 1);

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapTurId")
                        .HasColumnType("int");

                    b.Property<string>("KitapYazar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YayinEvi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KitapId");

                    b.HasIndex("KitapTurId");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("KutuphaneTakip.Models.KitapTur", b =>
                {
                    b.Property<int>("KitapTurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapTurId"), 1L, 1);

                    b.Property<string>("KitapTurAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KitapTurId");

                    b.ToTable("KitapTurler");
                });

            modelBuilder.Entity("KutuphaneTakip.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"), 1L, 1);

                    b.Property<string>("OgrenciAdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgrenciNo")
                        .HasColumnType("int");

                    b.Property<string>("OgrenciSinif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("KutuphaneTakip.Models.Adres", b =>
                {
                    b.HasOne("KutuphaneTakip.Models.Ogrenci", "Ogrenci")
                        .WithOne("Adres")
                        .HasForeignKey("KutuphaneTakip.Models.Adres", "OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("KutuphaneTakip.Models.Kitap", b =>
                {
                    b.HasOne("KutuphaneTakip.Models.KitapTur", "KitapTur")
                        .WithMany("Kitap")
                        .HasForeignKey("KitapTurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KitapTur");
                });

            modelBuilder.Entity("KutuphaneTakip.Models.KitapTur", b =>
                {
                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("KutuphaneTakip.Models.Ogrenci", b =>
                {
                    b.Navigation("Adres")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}