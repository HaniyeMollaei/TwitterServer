﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterServer.Data;

namespace TwitterServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TwitterServer.Models.Entity.ActivityLogEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActionTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ActionTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("ActorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TargetTweetId")
                        .HasColumnType("int");

                    b.Property<int>("TargetUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.HashtagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsageCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hashtags");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.HashtagTweetRelationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("HashtagEntityId")
                        .HasColumnType("int");

                    b.Property<int>("HashtagId")
                        .HasColumnType("int");

                    b.Property<int>("TweetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HashtagEntityId");

                    b.ToTable("HashtagTweetRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.LikeTweetUserRelationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("LikerUserId")
                        .HasColumnType("int");

                    b.Property<int?>("TweetEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TweetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TweetEntityId");

                    b.ToTable("LikeTweetUserRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.TweetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRetweet")
                        .HasColumnType("bit");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<int>("RetweetCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tweets");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.TweetHashtagRelationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HashtagId")
                        .HasColumnType("int");

                    b.Property<int?>("TweetEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TweetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TweetEntityId");

                    b.ToTable("TweetHashtagRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.TweetRetweeterRelationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RetweeterId")
                        .HasColumnType("int");

                    b.Property<int?>("TweetEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TweetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TweetEntityId");

                    b.ToTable("TweetRetweeterRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.UserFollowRelationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FollowerId")
                        .HasColumnType("int");

                    b.Property<int>("FollowingId")
                        .HasColumnType("int");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("UserFollowRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.UserTweetRelationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("TweetId")
                        .HasColumnType("int");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("UserTweetRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.HashtagTweetRelationEntity", b =>
                {
                    b.HasOne("TwitterServer.Models.Entity.HashtagEntity", null)
                        .WithMany("HashtagTweetRelations")
                        .HasForeignKey("HashtagEntityId");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.LikeTweetUserRelationEntity", b =>
                {
                    b.HasOne("TwitterServer.Models.Entity.TweetEntity", null)
                        .WithMany("LikeTweetUserRelations")
                        .HasForeignKey("TweetEntityId");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.TweetHashtagRelationEntity", b =>
                {
                    b.HasOne("TwitterServer.Models.Entity.TweetEntity", null)
                        .WithMany("TweetHashtagRelations")
                        .HasForeignKey("TweetEntityId");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.TweetRetweeterRelationEntity", b =>
                {
                    b.HasOne("TwitterServer.Models.Entity.TweetEntity", null)
                        .WithMany("TweetRetweeterRelations")
                        .HasForeignKey("TweetEntityId");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.UserFollowRelationEntity", b =>
                {
                    b.HasOne("TwitterServer.Models.Entity.UserEntity", null)
                        .WithMany("UserFollowRelations")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.UserTweetRelationEntity", b =>
                {
                    b.HasOne("TwitterServer.Models.Entity.UserEntity", null)
                        .WithMany("UserTweetRelations")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.HashtagEntity", b =>
                {
                    b.Navigation("HashtagTweetRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.TweetEntity", b =>
                {
                    b.Navigation("LikeTweetUserRelations");

                    b.Navigation("TweetHashtagRelations");

                    b.Navigation("TweetRetweeterRelations");
                });

            modelBuilder.Entity("TwitterServer.Models.Entity.UserEntity", b =>
                {
                    b.Navigation("UserFollowRelations");

                    b.Navigation("UserTweetRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
