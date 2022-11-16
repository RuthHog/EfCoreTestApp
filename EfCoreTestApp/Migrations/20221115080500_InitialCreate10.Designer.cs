﻿// <auto-generated />
using EfCoreTestApp.Respitory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreTestApp.Migrations
{
    [DbContext(typeof(FolderContext))]
    [Migration("20221115080500_InitialCreate10")]
    partial class InitialCreate10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreTestApp.Models.Item", b =>
                {
                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemNo1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ItemNo");

                    b.HasIndex("ItemNo1");

                    b.ToTable("items");
                });

            modelBuilder.Entity("EfCoreTestApp.Models.Item", b =>
                {
                    b.HasOne("EfCoreTestApp.Models.Item", null)
                        .WithMany("Children")
                        .HasForeignKey("ItemNo1");
                });

            modelBuilder.Entity("EfCoreTestApp.Models.Item", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
