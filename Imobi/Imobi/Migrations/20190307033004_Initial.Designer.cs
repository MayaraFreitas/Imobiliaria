﻿// <auto-generated />
using Imobi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imobi.Migrations
{
    [DbContext(typeof(ImobiContext))]
    [Migration("20190307033004_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Imobi.Models.ViewModels.Vistoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VistoriaDescricao");

                    b.HasKey("Id");

                    b.ToTable("Vistoria");
                });
#pragma warning restore 612, 618
        }
    }
}
