using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BusinessFlow.Data;

namespace BusinessFlow.Migrations
{
    [DbContext(typeof(VehicleDataContext))]
    [Migration("20160621180646_VehicleMigration")]
    partial class VehicleMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusinessFlow.Models.Part", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<long?>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("BusinessFlow.Models.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Engine")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("License")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Registration")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Transmission")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("BusinessFlow.Models.Part", b =>
                {
                    b.HasOne("BusinessFlow.Models.Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");
                });
        }
    }
}
