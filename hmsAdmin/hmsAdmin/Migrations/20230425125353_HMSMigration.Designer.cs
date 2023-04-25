﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hmsAdmin.Data;

#nullable disable

namespace hmsAdmin.Migrations
{
    [DbContext(typeof(HmsContext))]
    [Migration("20230425125353_HMSMigration")]
    partial class HMSMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hmsAdmin.HMSModels.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("FkDept")
                        .HasColumnType("int")
                        .HasColumnName("fk_dept");

                    b.Property<int?>("FkPat")
                        .HasColumnType("int")
                        .HasColumnName("fk_pat");

                    b.Property<int?>("FkPay")
                        .HasColumnType("int")
                        .HasColumnName("fk_pay");

                    b.Property<int?>("FkStat")
                        .HasColumnType("int")
                        .HasColumnName("fk_stat");

                    b.Property<int?>("FkTt")
                        .HasColumnType("int")
                        .HasColumnName("fk_tt");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("PK__appointm__3213E83F33B6A52E");

                    b.HasIndex("FkDept");

                    b.HasIndex("FkPat");

                    b.HasIndex("FkPay");

                    b.HasIndex("FkStat");

                    b.HasIndex("FkTt");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Department", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("AppPrice")
                        .HasColumnType("int")
                        .HasColumnName("app_price");

                    b.Property<int?>("DrNumber")
                        .HasColumnType("int")
                        .HasColumnName("dr_number");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<int?>("NsNumber")
                        .HasColumnType("int")
                        .HasColumnName("ns_number");

                    b.HasKey("Id")
                        .HasName("PK__departme__3213E83FBF388771");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Diagnose", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Analysis")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("analysis");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<int?>("FkApp")
                        .HasColumnType("int")
                        .HasColumnName("fk_app");

                    b.Property<string>("Prescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("prescription");

                    b.HasKey("Id")
                        .HasName("PK__diagnose__3213E83F7B00B9D0");

                    b.HasIndex("FkApp");

                    b.ToTable("diagnose");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("address");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<int>("Experience")
                        .HasColumnType("int")
                        .HasColumnName("experience");

                    b.Property<int?>("FkDept")
                        .HasColumnType("int")
                        .HasColumnName("fk_dept");

                    b.Property<int?>("FkStatus")
                        .HasColumnType("int")
                        .HasColumnName("fk_status");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("gender");

                    b.Property<string>("Image")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("PersonalProfile")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("personal_profile");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("char(11)")
                        .HasColumnName("phone")
                        .IsFixedLength();

                    b.HasKey("Id")
                        .HasName("PK__doctors__3213E83F918D10AD");

                    b.HasIndex("FkDept");

                    b.HasIndex("FkStatus");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Lab", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("AnaName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ana_name");

                    b.Property<int>("Cost")
                        .HasColumnType("int")
                        .HasColumnName("cost");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("FkApp")
                        .HasColumnType("int")
                        .HasColumnName("fk_app");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("char(20)")
                        .HasColumnName("result")
                        .IsFixedLength();

                    b.HasKey("Id")
                        .HasName("PK__lab__3213E83F64C88213");

                    b.HasIndex("FkApp");

                    b.ToTable("lab");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Medicine", b =>
                {
                    b.Property<int?>("FkDia")
                        .HasColumnType("int")
                        .HasColumnName("fk_dia");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasIndex("FkDia");

                    b.ToTable("medicine");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("address");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<int?>("FkDept")
                        .HasColumnType("int")
                        .HasColumnName("fk_dept");

                    b.Property<int?>("FkStatus")
                        .HasColumnType("int")
                        .HasColumnName("fk_status");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("gender");

                    b.Property<string>("Image")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("char(11)")
                        .HasColumnName("phone")
                        .IsFixedLength();

                    b.HasKey("Id")
                        .HasName("PK__nurses__3213E83F13C92838");

                    b.HasIndex("FkDept");

                    b.HasIndex("FkStatus");

                    b.ToTable("nurses");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Patient", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("address");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("gender");

                    b.Property<string>("Image")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<long>("Nid")
                        .HasColumnType("bigint")
                        .HasColumnName("NID");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("char(11)")
                        .HasColumnName("phone")
                        .IsFixedLength();

                    b.HasKey("Id")
                        .HasName("PK__patients__3213E83F6DEFA952");

                    b.HasIndex(new[] { "Nid" }, "UQ__patients__C7DEC332A91E8FE2")
                        .IsUnique();

                    b.ToTable("patients");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Payment", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Method")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("method");

                    b.HasKey("Id")
                        .HasName("PK__payment__3213E83FC7C36133");

                    b.ToTable("payment");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Pharmacy", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<int?>("Cost")
                        .HasColumnType("int")
                        .HasColumnName("cost");

                    b.Property<string>("MedName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("med_name");

                    b.HasKey("Id")
                        .HasName("PK__pharmacy__3213E83FD9C3245B");

                    b.ToTable("pharmacy");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Status", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__status__3213E83FAC4D67DD");

                    b.ToTable("status");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Timedept", b =>
                {
                    b.Property<int>("AvailableApp")
                        .HasColumnType("int")
                        .HasColumnName("available_app");

                    b.Property<int>("AvailableDr")
                        .HasColumnType("int")
                        .HasColumnName("available_dr");

                    b.Property<int?>("FkDept")
                        .HasColumnType("int")
                        .HasColumnName("fk_dept");

                    b.Property<int?>("FkTime")
                        .HasColumnType("int")
                        .HasColumnName("fk_time");

                    b.HasIndex("FkDept");

                    b.HasIndex("FkTime");

                    b.ToTable("timedept");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Timetable", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("DayDate")
                        .HasColumnType("date")
                        .HasColumnName("day_date");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("day_name");

                    b.HasKey("Id")
                        .HasName("PK__timetabl__3213E83FD8E7D805");

                    b.ToTable("timetable");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Appointment", b =>
                {
                    b.HasOne("hmsAdmin.HMSModels.Department", "FkDeptNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("FkDept")
                        .HasConstraintName("FK_appointments_departments");

                    b.HasOne("hmsAdmin.HMSModels.Patient", "FkPatNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("FkPat")
                        .HasConstraintName("FK_appointments_patients");

                    b.HasOne("hmsAdmin.HMSModels.Payment", "FkPayNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("FkPay")
                        .HasConstraintName("FK_appointments_payment");

                    b.HasOne("hmsAdmin.HMSModels.Status", "FkStatNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("FkStat")
                        .HasConstraintName("FK_appointments_status");

                    b.HasOne("hmsAdmin.HMSModels.Timetable", "FkTtNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("FkTt")
                        .HasConstraintName("FK_appointments_timetable");

                    b.Navigation("FkDeptNavigation");

                    b.Navigation("FkPatNavigation");

                    b.Navigation("FkPayNavigation");

                    b.Navigation("FkStatNavigation");

                    b.Navigation("FkTtNavigation");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Diagnose", b =>
                {
                    b.HasOne("hmsAdmin.HMSModels.Appointment", "FkAppNavigation")
                        .WithMany("Diagnoses")
                        .HasForeignKey("FkApp")
                        .HasConstraintName("FK_diagnose_appointments");

                    b.Navigation("FkAppNavigation");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Doctor", b =>
                {
                    b.HasOne("hmsAdmin.HMSModels.Department", "FkDeptNavigation")
                        .WithMany("Doctors")
                        .HasForeignKey("FkDept")
                        .HasConstraintName("FK_doctors_departments");

                    b.HasOne("hmsAdmin.HMSModels.Status", "FkStatusNavigation")
                        .WithMany("Doctors")
                        .HasForeignKey("FkStatus")
                        .HasConstraintName("FK_doctors_status");

                    b.Navigation("FkDeptNavigation");

                    b.Navigation("FkStatusNavigation");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Lab", b =>
                {
                    b.HasOne("hmsAdmin.HMSModels.Appointment", "FkAppNavigation")
                        .WithMany("Labs")
                        .HasForeignKey("FkApp")
                        .HasConstraintName("FK_lab_appointments");

                    b.Navigation("FkAppNavigation");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Medicine", b =>
                {
                    b.HasOne("hmsAdmin.HMSModels.Diagnose", "FkDiaNavigation")
                        .WithMany()
                        .HasForeignKey("FkDia")
                        .HasConstraintName("FK_medicine_diagnose");

                    b.Navigation("FkDiaNavigation");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Nurse", b =>
                {
                    b.HasOne("hmsAdmin.HMSModels.Department", "FkDeptNavigation")
                        .WithMany("Nurses")
                        .HasForeignKey("FkDept")
                        .HasConstraintName("FK_nurses_departments");

                    b.HasOne("hmsAdmin.HMSModels.Status", "FkStatusNavigation")
                        .WithMany("Nurses")
                        .HasForeignKey("FkStatus")
                        .HasConstraintName("FK_nurses_status");

                    b.Navigation("FkDeptNavigation");

                    b.Navigation("FkStatusNavigation");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Timedept", b =>
                {
                    b.HasOne("hmsAdmin.HMSModels.Department", "FkDeptNavigation")
                        .WithMany()
                        .HasForeignKey("FkDept")
                        .HasConstraintName("FK_timedept_departments");

                    b.HasOne("hmsAdmin.HMSModels.Timetable", "FkTimeNavigation")
                        .WithMany()
                        .HasForeignKey("FkTime")
                        .HasConstraintName("FK_timedept_timetable");

                    b.Navigation("FkDeptNavigation");

                    b.Navigation("FkTimeNavigation");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Appointment", b =>
                {
                    b.Navigation("Diagnoses");

                    b.Navigation("Labs");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Department", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Payment", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Status", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("hmsAdmin.HMSModels.Timetable", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}