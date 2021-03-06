// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XYZCompanyAssetsManagement.Repositories;

#nullable disable

namespace XYZCompanyAssetsManagement.Migrations
{
    [DbContext(typeof(Repository))]
    [Migration("20220419070019_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XYZCompanyAssetsManagement.Models.AssetsDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetsDetails");
                });

            modelBuilder.Entity("XYZCompanyAssetsManagement.Models.AssetsMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssetsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfReturn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetsId");

                    b.HasIndex("EmpId");

                    b.ToTable("AssetsMapping");
                });

            modelBuilder.Entity("XYZCompanyAssetsManagement.Models.EmpDetails", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmpDetails");
                });

            modelBuilder.Entity("XYZCompanyAssetsManagement.Models.AssetsMapping", b =>
                {
                    b.HasOne("XYZCompanyAssetsManagement.Models.AssetsDetails", "AssetsDetails")
                        .WithMany()
                        .HasForeignKey("AssetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XYZCompanyAssetsManagement.Models.EmpDetails", "EmpDetails")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetsDetails");

                    b.Navigation("EmpDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
