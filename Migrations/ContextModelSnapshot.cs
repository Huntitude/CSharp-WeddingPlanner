﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeddingPlannerRedo.Models;

namespace WeddingPlannerRedo.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WeddingPlannerRedo.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WeddingPlannerRedo.Models.WeddingGuest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IsAttending");

                    b.Property<int>("PlanId");

                    b.Property<int>("UserId");

                    b.HasKey("GuestId");

                    b.HasIndex("PlanId");

                    b.HasIndex("UserId");

                    b.ToTable("WeddingGuests");
                });

            modelBuilder.Entity("WeddingPlannerRedo.Models.WeddingPlan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CreatorId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("WedderOne")
                        .IsRequired();

                    b.Property<string>("WedderTwo")
                        .IsRequired();

                    b.Property<string>("WeddingAddress")
                        .IsRequired();

                    b.Property<DateTime?>("WeddingDate")
                        .IsRequired();

                    b.HasKey("PlanId");

                    b.ToTable("WeddingPlans");
                });

            modelBuilder.Entity("WeddingPlannerRedo.Models.WeddingGuest", b =>
                {
                    b.HasOne("WeddingPlannerRedo.Models.WeddingPlan", "WeddingPlan")
                        .WithMany("Guests")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WeddingPlannerRedo.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}