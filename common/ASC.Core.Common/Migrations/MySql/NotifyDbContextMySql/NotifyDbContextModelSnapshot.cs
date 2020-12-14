﻿// <auto-generated />
using System;
using ASC.Core.Common.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ASC.Core.Common.Migrations.MySql.NotifyDbContextMySql
{
    [DbContext(typeof(MySqlNotifyDbContext))]
    partial class NotifyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASC.Core.Common.EF.Model.NotifyInfo", b =>
                {
                    b.Property<int>("NotifyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("notify_id")
                        .HasColumnType("int");

                    b.Property<int>("Attempts")
                        .HasColumnName("attempts")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnName("modify_date")
                        .HasColumnType("datetime");

                    b.Property<int>("Priority")
                        .HasColumnName("priority")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnName("state")
                        .HasColumnType("int");

                    b.HasKey("NotifyId")
                        .HasName("PRIMARY");

                    b.HasIndex("State")
                        .HasName("state");

                    b.ToTable("notify_info");
                });

            modelBuilder.Entity("ASC.Core.Common.EF.Model.NotifyQueue", b =>
                {
                    b.Property<int>("NotifyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("notify_id")
                        .HasColumnType("int");

                    b.Property<string>("Attachments")
                        .HasColumnName("attachments")
                        .HasColumnType("text")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("AutoSubmitted")
                        .HasColumnName("auto_submitted")
                        .HasColumnType("varchar(64)")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("Content")
                        .HasColumnName("content")
                        .HasColumnType("text")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("ContentType")
                        .HasColumnName("content_type")
                        .HasColumnType("varchar(64)")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnName("creation_date")
                        .HasColumnType("datetime");

                    b.Property<string>("Reciever")
                        .HasColumnName("reciever")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("ReplyTo")
                        .HasColumnName("reply_to")
                        .HasColumnType("varchar(1024)")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("Sender")
                        .HasColumnName("sender")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("SenderType")
                        .HasColumnName("sender_type")
                        .HasColumnType("varchar(64)")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("Subject")
                        .HasColumnName("subject")
                        .HasColumnType("varchar(1024)")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<int>("TenantId")
                        .HasColumnName("tenant_id")
                        .HasColumnType("int");

                    b.HasKey("NotifyId")
                        .HasName("PRIMARY");

                    b.ToTable("notify_queue");
                });
#pragma warning restore 612, 618
        }
    }
}