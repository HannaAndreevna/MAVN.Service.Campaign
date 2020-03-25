﻿// <auto-generated />
using System;
using Lykke.Service.Campaign.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.Campaign.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CampaignContext))]
    [Migration("20190702143552_AddRules")]
    partial class AddRules
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("campaign")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.BonusTypeEntity", b =>
                {
                    b.Property<string>("Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("type")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnName("creation_date");

                    b.Property<string>("DisplayName")
                        .HasColumnName("display_name");

                    b.Property<bool>("IsAvailable")
                        .HasColumnName("is_available");

                    b.HasKey("Type");

                    b.ToTable("bonus_type");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.CampaignEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("CompletionCount")
                        .HasColumnName("completion_count");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnName("creation_date");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<DateTime>("FromDate")
                        .HasColumnName("from_date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted");

                    b.Property<bool>("IsEnabled")
                        .HasColumnName("is_enabled");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<decimal>("Reward")
                        .HasColumnName("reward");

                    b.Property<string>("RewardType")
                        .HasColumnName("reward_type");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnName("to_date");

                    b.HasKey("Id");

                    b.ToTable("campaign");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.ConditionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("BonusTypeName")
                        .HasColumnName("bonus_type");

                    b.Property<Guid>("CampaignEntityId")
                        .HasColumnName("campaign_id");

                    b.Property<int>("CompletionCount")
                        .HasColumnName("completion_count");

                    b.Property<decimal>("ImmediateReward")
                        .HasColumnName("immediate_reward");

                    b.HasKey("Id");

                    b.HasIndex("BonusTypeName");

                    b.HasIndex("CampaignEntityId");

                    b.ToTable("condition");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.Configuration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("LastProcessedDate");

                    b.HasKey("Id");

                    b.ToTable("configuration");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.EarnRuleContentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("EarnRuleId")
                        .HasColumnName("earn_rule_id");

                    b.Property<int>("Localization")
                        .HasColumnName("localization");

                    b.Property<int>("RuleContentType")
                        .HasColumnName("content_type");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("EarnRuleId");

                    b.ToTable("earn_rule_content");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.EarnRuleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnName("creation_date");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Title")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("earn_rules");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.SpendRuleContentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("Localization")
                        .HasColumnName("localization");

                    b.Property<int>("RuleContentType")
                        .HasColumnName("content_type");

                    b.Property<Guid>("SpendRuleId")
                        .HasColumnName("spend_rule_id");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("SpendRuleId");

                    b.ToTable("spend_rule_contents");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.SpendRuleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnName("creation_date");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Title")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("spend_rules");
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.ConditionEntity", b =>
                {
                    b.HasOne("Lykke.Service.Campaign.MsSqlRepositories.Entities.BonusTypeEntity", "BonusTypeEntity")
                        .WithMany("ConditionEntities")
                        .HasForeignKey("BonusTypeName");

                    b.HasOne("Lykke.Service.Campaign.MsSqlRepositories.Entities.CampaignEntity", "CampaignEntity")
                        .WithMany("ConditionEntities")
                        .HasForeignKey("CampaignEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.EarnRuleContentEntity", b =>
                {
                    b.HasOne("Lykke.Service.Campaign.MsSqlRepositories.Entities.EarnRuleEntity", "EarnRule")
                        .WithMany("EarnRuleContents")
                        .HasForeignKey("EarnRuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lykke.Service.Campaign.MsSqlRepositories.Entities.SpendRuleContentEntity", b =>
                {
                    b.HasOne("Lykke.Service.Campaign.MsSqlRepositories.Entities.SpendRuleEntity", "SpendRule")
                        .WithMany("SpendRuleContents")
                        .HasForeignKey("SpendRuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
