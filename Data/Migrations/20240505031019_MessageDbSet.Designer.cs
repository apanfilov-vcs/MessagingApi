﻿// <auto-generated />
using System;
using DbUserConversations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbUserConversations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240505031019_MessageDbSet")]
    partial class MessageDbSet
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("ConversationUser", b =>
                {
                    b.Property<string>("ConversationsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsersId")
                        .HasColumnType("TEXT");

                    b.HasKey("ConversationsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ConversationUser");
                });

            modelBuilder.Entity("DbUserConversations.Models.Conversation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("DbUserConversations.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FromUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeSent")
                        .HasColumnType("TEXT");

                    b.Property<string>("ToConversationId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("ToConversationId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DbUserConversations.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ConversationUser", b =>
                {
                    b.HasOne("DbUserConversations.Models.Conversation", null)
                        .WithMany()
                        .HasForeignKey("ConversationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbUserConversations.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbUserConversations.Models.Message", b =>
                {
                    b.HasOne("DbUserConversations.Models.User", "FromUser")
                        .WithMany("SentMessages")
                        .HasForeignKey("FromUserId");

                    b.HasOne("DbUserConversations.Models.Conversation", "ToConversation")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ToConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromUser");

                    b.Navigation("ToConversation");
                });

            modelBuilder.Entity("DbUserConversations.Models.Conversation", b =>
                {
                    b.Navigation("ReceivedMessages");
                });

            modelBuilder.Entity("DbUserConversations.Models.User", b =>
                {
                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
