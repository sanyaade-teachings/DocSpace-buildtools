﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ASC.Calendar.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ASC.Calendar.Core.Dao.Models;
using Microsoft.Extensions.DependencyInjection;
using ASC.Core.Common.EF;
using ASC.Common;

namespace ASC.Calendar.Core.Dao
{
    public partial class CalendarDbContext : BaseDbContext
    {
        public CalendarDbContext()
        {
        }

        public CalendarDbContext(DbContextOptions<CalendarDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CalendarCalendarItem> CalendarCalendarItem { get; set; }
        public virtual DbSet<CalendarCalendarUser> CalendarCalendarUser { get; set; }
        public virtual DbSet<CalendarCalendars> CalendarCalendars { get; set; }
        public virtual DbSet<CalendarEventHistory> CalendarEventHistory { get; set; }
        public virtual DbSet<CalendarEventItem> CalendarEventItem { get; set; }
        public virtual DbSet<CalendarEventUser> CalendarEventUser { get; set; }
        public virtual DbSet<CalendarEvents> CalendarEvents { get; set; }
        public virtual DbSet<CalendarNotifications> CalendarNotifications { get; set; }
        public virtual DbSet<CalendarTodos> CalendarTodos { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalendarCalendarItem>(entity =>
            {
                entity.HasKey(e => new { e.CalendarId, e.ItemId, e.IsGroup })
                    .HasName("PRIMARY");

                entity.Property(e => e.ItemId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarCalendarUser>(entity =>
            {
                entity.HasKey(e => new { e.CalendarId, e.ExtCalendarId, e.UserId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UserId)
                    .HasDatabaseName("user_id");

                entity.Property(e => e.ExtCalendarId)
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.BackgroundColor)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TextColor)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TimeZone)
                    .HasDefaultValueSql("'UTC'")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarCalendars>(entity =>
            {
                entity.HasIndex(e => new { e.Tenant, e.OwnerId })
                    .HasDatabaseName("owner_id");

                entity.Property(e => e.BackgroundColor)
                    .HasDefaultValueSql("'#fa9191'")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CaldavGuid)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.IcalUrl)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TextColor)
                    .HasDefaultValueSql("'#000000'")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TimeZone)
                    .HasDefaultValueSql("'UTC'")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarEventHistory>(entity =>
            {
                entity.HasKey(e => new { e.Tenant, e.CalendarId, e.EventUid })
                    .HasName("PRIMARY");

                entity.HasIndex(e => new { e.Tenant, e.EventId })
                    .HasDatabaseName("event_id");

                entity.Property(e => e.EventUid)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Ics)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarEventItem>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.ItemId, e.IsGroup })
                    .HasName("PRIMARY");

                entity.Property(e => e.ItemId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarEventUser>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.UserId })
                    .HasName("PRIMARY");

                entity.Property(e => e.UserId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarEvents>(entity =>
            {
                entity.HasIndex(e => new { e.Tenant, e.CalendarId })
                    .HasDatabaseName("calendar_id");

                entity.Property(e => e.Description)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Rrule)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Uid)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarNotifications>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.EventId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.EventId)
                    .HasDatabaseName("event_id");

                entity.HasIndex(e => e.NotifyDate)
                    .HasDatabaseName("notify_date");

                entity.Property(e => e.UserId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Rrule)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TimeZone)
                    .HasDefaultValueSql("'UTC'")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CalendarTodos>(entity =>
            {
                entity.HasIndex(e => new { e.Tenant, e.CalendarId })
                    .HasDatabaseName("calendar_id");

                entity.Property(e => e.Description)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Uid)
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

    public static class CalendarDbExtension
    {
        public static DIHelper AddCalendarDbContextService(this DIHelper services)
        {
            return services.AddDbContextManagerService<CalendarDbContext>();
        }
    }
}