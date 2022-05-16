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
    [Migration("20220516203835_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("RimionshipServer.Models.Participant", b =>
                {
                    b.Property<string>("TwitchID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModID")
                        .HasColumnType("TEXT");

                    b.HasKey("TwitchID");

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
                        .HasColumnType("TEXT");

                    b.Property<string>("ParticipantTwitchID")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantTwitchID");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("RimionshipServer.Models.Stat", b =>
                {
                    b.HasOne("RimionshipServer.Models.Participant", null)
                        .WithMany("Stats")
                        .HasForeignKey("ParticipantTwitchID");
                });

            modelBuilder.Entity("RimionshipServer.Models.Participant", b =>
                {
                    b.Navigation("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}
