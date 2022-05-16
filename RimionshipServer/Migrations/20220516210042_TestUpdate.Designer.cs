﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RimionshipServer;

namespace RimionshipServer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220516210042_TestUpdate")]
    partial class TestUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("RimionshipServer.Models.Participant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mod")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("RimionshipServer.Models.Stat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ColonyWealth")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("RimionshipServer.Models.Stat", b =>
                {
                    b.HasOne("RimionshipServer.Models.Participant", null)
                        .WithMany("Stats")
                        .HasForeignKey("ParticipantId");
                });

            modelBuilder.Entity("RimionshipServer.Models.Participant", b =>
                {
                    b.Navigation("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}
