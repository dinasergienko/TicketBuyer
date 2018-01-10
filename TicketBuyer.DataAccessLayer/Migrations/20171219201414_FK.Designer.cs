﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TicketBuyer.DataAccessLayer;

namespace TicketBuyer.DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171219201414_FK")]
    partial class FK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Auth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Auths");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Cancellation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Cancellations");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.CompanyNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("CompanyNews");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Information");

                    b.Property<string>("Name");

                    b.Property<int>("PlaceId");

                    b.Property<int>("StatusId");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("EventComments");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("EventId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("EventNews");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<string>("Photo");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("EventPhotos");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("SaleId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SaleId");

                    b.ToTable("EventSales");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("EventStatuses");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.GiftCertificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.ToTable("GiftCertificates");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.GiftCertificateOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GiftCertificateId");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("GiftCertificateId");

                    b.HasIndex("OrderId");

                    b.ToTable("GiftCertificateOrder");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<bool>("IsSent");

                    b.Property<int>("NotificationDefenitionId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("NotificationDefenitionId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.NotificationDefenition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("NotificationDefenitions");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PaymentId");

                    b.Property<int>("StatusId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId")
                        .IsUnique()
                        .HasFilter("[PaymentId] IS NOT NULL");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CancellationId");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("PaymentTypeId");

                    b.HasKey("Id");

                    b.HasIndex("CancellationId")
                        .IsUnique()
                        .HasFilter("[CancellationId] IS NOT NULL");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Information");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.PlacePhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Photo");

                    b.Property<int>("PlaceId");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("PlacePhotos");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<float>("EventPrice");

                    b.Property<int>("SectorId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SectorId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<float>("Percent");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.SalePlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("SalePlaces");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Seating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Row");

                    b.Property<int>("Seat");

                    b.Property<int>("SectorId");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Seatings");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Limit");

                    b.Property<int>("PlaceId");

                    b.Property<string>("Title");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.HasIndex("TypeId");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.SectorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("SectorTypes");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("OrderId");

                    b.Property<float>("Price");

                    b.Property<int?>("SeatingId");

                    b.Property<int>("SectorId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("OrderId");

                    b.HasIndex("SeatingId");

                    b.HasIndex("SectorId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthId");

                    b.Property<int>("RoleId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("AuthId")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.UserPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventTypeId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.WishEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("WishEvents");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Event", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Place", "Place")
                        .WithMany("Events")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.EventStatus", "Status")
                        .WithMany("Events")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.EventType", "Type")
                        .WithMany("Events")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventComment", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("EventComments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("EventComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventNews", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("EventNews")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventPhoto", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("EventPhotos")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventSale", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("EventSales")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Sale", "Sale")
                        .WithMany("EventSales")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.GiftCertificateOrder", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.GiftCertificate", "GiftCertificate")
                        .WithMany("GiftCertificateOrders")
                        .HasForeignKey("GiftCertificateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Order", "Order")
                        .WithMany("GiftCertificateOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Notification", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.NotificationDefenition", "NotificationDefenition")
                        .WithMany("Notifications")
                        .HasForeignKey("NotificationDefenitionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Order", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Payment", "Payment")
                        .WithOne("Order")
                        .HasForeignKey("TicketBuyer.DataAccessLayer.Entities.Order", "PaymentId");

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.OrderStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Payment", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Cancellation", "Cancellation")
                        .WithOne("Payment")
                        .HasForeignKey("TicketBuyer.DataAccessLayer.Entities.Payment", "CancellationId");

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.PlacePhoto", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Place", "Place")
                        .WithMany("PlacePhotos")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Price", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Sector", "Sector")
                        .WithMany("Prices")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Seating", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Sector", "Sector")
                        .WithMany("Seatings")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Sector", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Place", "Place")
                        .WithMany("Sectors")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.SectorType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Ticket", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Order", "Order")
                        .WithMany("Tickets")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Seating", "Seating")
                        .WithMany("Tickets")
                        .HasForeignKey("SeatingId");

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Sector", "Sector")
                        .WithMany("Tickets")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.User", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Auth", "Auth")
                        .WithOne("User")
                        .HasForeignKey("TicketBuyer.DataAccessLayer.Entities.User", "AuthId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.UserPreference", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.EventType", "EventType")
                        .WithMany("UserPreferences")
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("UserPreferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.WishEvent", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("WishEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("WishEvents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
