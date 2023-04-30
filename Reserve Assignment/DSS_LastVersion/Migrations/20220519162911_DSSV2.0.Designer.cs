﻿// <auto-generated />
using DSS_LastVersion.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DSS_LastVersion.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220519162911_DSSV2.0")]
    partial class DSSV20
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DSS_LastVersion.Models.Assassin", b =>
                {
                    b.Property<int>("AssassinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssassinID"), 1L, 1);

                    b.Property<string>("AssassinName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AssassinRank")
                        .HasColumnType("int");

                    b.Property<int>("BrotherhoodID")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssassinID");

                    b.HasIndex("BrotherhoodID");

                    b.ToTable("Assassins");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Brotherhood", b =>
                {
                    b.Property<int>("BrotherhoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrotherhoodId"), 1L, 1);

                    b.Property<int>("BrotherhoodLevel")
                        .HasColumnType("int");

                    b.Property<string>("BrotherhoodName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrotherhoodId");

                    b.ToTable("Brotherhoods");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Contract", b =>
                {
                    b.Property<int>("ContractID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractID"), 1L, 1);

                    b.Property<int>("AssassinID")
                        .HasColumnType("int");

                    b.Property<int>("MissionID")
                        .HasColumnType("int");

                    b.HasKey("ContractID");

                    b.HasIndex("AssassinID");

                    b.HasIndex("MissionID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Mission", b =>
                {
                    b.Property<int>("MissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MissionID"), 1L, 1);

                    b.Property<int>("MissionLevel")
                        .HasColumnType("int");

                    b.Property<string>("MissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MissionID");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Assassin", b =>
                {
                    b.HasOne("DSS_LastVersion.Models.Brotherhood", "Brotherhoods")
                        .WithMany("Assassins")
                        .HasForeignKey("BrotherhoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brotherhoods");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Contract", b =>
                {
                    b.HasOne("DSS_LastVersion.Models.Assassin", "Assassins")
                        .WithMany("Contracts")
                        .HasForeignKey("AssassinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DSS_LastVersion.Models.Mission", "Missions")
                        .WithMany("Contracts")
                        .HasForeignKey("MissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assassins");

                    b.Navigation("Missions");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Assassin", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Brotherhood", b =>
                {
                    b.Navigation("Assassins");
                });

            modelBuilder.Entity("DSS_LastVersion.Models.Mission", b =>
                {
                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}