﻿// <auto-generated />
using System;
using BookMyEvent.Services.EventCatalog.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookMyEvent.Services.EventCatalog.Migrations
{
    [DbContext(typeof(EventCatalogDbContext))]
    [Migration("20210105101748_AddedVenueDetails")]
    partial class AddedVenueDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookMyEvent.Services.EventCatalog.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Name = "Concerts"
                        },
                        new
                        {
                            CategoryId = new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                            Name = "Musicals"
                        },
                        new
                        {
                            CategoryId = new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                            Name = "Plays"
                        },
                        new
                        {
                            CategoryId = new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                            Name = "Conferences"
                        });
                });

            modelBuilder.Entity("BookMyEvent.Services.EventCatalog.Entities.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VenueId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                            Artist = "John Elbert",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Date = new DateTime(2021, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                            ImageUrl = "https://neilmorrisseypluralsight.blob.core.windows.net/imgs/banjo.jpg",
                            Name = "John Egbert Live",
                            Price = 65,
                            VenueId = new Guid("bcd82a4c-881e-44fc-ba94-c857ab1ab071")
                        },
                        new
                        {
                            EventId = new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                            Artist = "Michael Johnson",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Date = new DateTime(2021, 10, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?",
                            ImageUrl = "https://neilmorrisseypluralsight.blob.core.windows.net/imgs/michael.jpg",
                            Name = "The State of Affairs: Michael Live!",
                            Price = 85,
                            VenueId = new Guid("bcd82a4c-881e-44fc-ba94-c857ab1ab071")
                        },
                        new
                        {
                            EventId = new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                            Artist = "DJ 'The Mike'",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Date = new DateTime(2021, 5, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
                            ImageUrl = "https://neilmorrisseypluralsight.blob.core.windows.net/imgs/dj.jpg",
                            Name = "Clash of the DJs",
                            Price = 85,
                            VenueId = new Guid("45929e17-9f3c-4dd4-8043-126c34733dc5")
                        },
                        new
                        {
                            EventId = new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                            Artist = "Manuel Santinonisi",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Date = new DateTime(2021, 5, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Get on the hype of Spanish Guitar concerts with Manuel.",
                            ImageUrl = "https://neilmorrisseypluralsight.blob.core.windows.net/imgs/guitar.jpg",
                            Name = "Spanish guitar hits with Manuel",
                            Price = 25,
                            VenueId = new Guid("45929e17-9f3c-4dd4-8043-126c34733dc5")
                        },
                        new
                        {
                            EventId = new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                            Artist = "Many",
                            CategoryId = new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                            Date = new DateTime(2021, 11, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The best tech conference in the world",
                            ImageUrl = "https://neilmorrisseypluralsight.blob.core.windows.net/imgs/conf.jpg",
                            Name = "Techorama 2021",
                            Price = 400,
                            VenueId = new Guid("2d8f80ca-616f-4928-bd09-a1849fec5a9a")
                        },
                        new
                        {
                            EventId = new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                            Artist = "Nick Sailor",
                            CategoryId = new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                            Date = new DateTime(2021, 9, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.",
                            ImageUrl = "https://neilmorrisseypluralsight.blob.core.windows.net/imgs/musical.jpg",
                            Name = "To the Moon and Back",
                            Price = 135,
                            VenueId = new Guid("2d8f80ca-616f-4928-bd09-a1849fec5a9a")
                        });
                });

            modelBuilder.Entity("BookMyEvent.Services.EventCatalog.Entities.IntegrationEventLog", b =>
                {
                    b.Property<int>("IntegrationEventLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IntegrationEventBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntegrationEventType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceBusTopicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntegrationEventLogId");

                    b.ToTable("IntegrationEventLogs");
                });

            modelBuilder.Entity("BookMyEvent.Services.EventCatalog.Entities.Venue", b =>
                {
                    b.Property<Guid>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueId");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            VenueId = new Guid("bcd82a4c-881e-44fc-ba94-c857ab1ab071"),
                            City = "Toronto",
                            Country = "Canada",
                            Name = "Massey Hall"
                        },
                        new
                        {
                            VenueId = new Guid("45929e17-9f3c-4dd4-8043-126c34733dc5"),
                            City = "Montreal",
                            Country = "Canada",
                            Name = "L'Olympia"
                        },
                        new
                        {
                            VenueId = new Guid("2d8f80ca-616f-4928-bd09-a1849fec5a9a"),
                            City = "Vancouver",
                            Country = "Canada",
                            Name = "Commodore Ballroom"
                        });
                });

            modelBuilder.Entity("BookMyEvent.Services.EventCatalog.Entities.Event", b =>
                {
                    b.HasOne("BookMyEvent.Services.EventCatalog.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMyEvent.Services.EventCatalog.Entities.Venue", "Venue")
                        .WithMany("Events")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
