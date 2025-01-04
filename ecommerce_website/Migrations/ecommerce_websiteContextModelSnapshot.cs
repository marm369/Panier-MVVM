﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce_website.Data;

#nullable disable

namespace ecommerce_website.Migrations
{
    [DbContext(typeof(ecommerce_websiteContext))]
    partial class ecommerce_websiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ecommerce_website.Models.Achat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DateAchat")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Achats");
                });

            modelBuilder.Entity("ecommerce_website.Models.Categorie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nomCategorie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ecommerce_website.Models.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Produitid")
                        .HasColumnType("int");

                    b.Property<bool>("imagePrincipale")
                        .HasColumnType("bit");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Produitid");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("ecommerce_website.Models.LignePanier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Produitid")
                        .HasColumnType("int");

                    b.Property<int>("id_achat")
                        .HasColumnType("int");

                    b.Property<int>("id_produit")
                        .HasColumnType("int");

                    b.Property<double>("prixdevente")
                        .HasColumnType("float");

                    b.Property<int>("quantite_ligne")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Produitid");

                    b.HasIndex("id_achat");

                    b.HasIndex("id_produit");

                    b.ToTable("LignesAchat");
                });

            modelBuilder.Entity("ecommerce_website.Models.Produit", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("categorieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateAjout")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomProduit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("prixProduit")
                        .HasColumnType("float");

                    b.Property<int>("qteStock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categorieId");

                    b.ToTable("Produit");
                });

            modelBuilder.Entity("ecommerce_website.Models.Image", b =>
                {
                    b.HasOne("ecommerce_website.Models.Produit", null)
                        .WithMany("images")
                        .HasForeignKey("Produitid");
                });

            modelBuilder.Entity("ecommerce_website.Models.LignePanier", b =>
                {
                    b.HasOne("ecommerce_website.Models.Produit", null)
                        .WithMany("lignesPanier")
                        .HasForeignKey("Produitid");

                    b.HasOne("ecommerce_website.Models.Achat", "achat")
                        .WithMany("lignesPanier")
                        .HasForeignKey("id_achat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ecommerce_website.Models.Produit", "produit")
                        .WithMany()
                        .HasForeignKey("id_produit")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("achat");

                    b.Navigation("produit");
                });

            modelBuilder.Entity("ecommerce_website.Models.Produit", b =>
                {
                    b.HasOne("ecommerce_website.Models.Categorie", "categorie")
                        .WithMany("produits")
                        .HasForeignKey("categorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorie");
                });

            modelBuilder.Entity("ecommerce_website.Models.Achat", b =>
                {
                    b.Navigation("lignesPanier");
                });

            modelBuilder.Entity("ecommerce_website.Models.Categorie", b =>
                {
                    b.Navigation("produits");
                });

            modelBuilder.Entity("ecommerce_website.Models.Produit", b =>
                {
                    b.Navigation("images");

                    b.Navigation("lignesPanier");
                });
#pragma warning restore 612, 618
        }
    }
}
