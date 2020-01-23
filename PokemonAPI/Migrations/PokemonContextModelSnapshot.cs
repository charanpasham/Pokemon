﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonAPI.Context;

namespace PokemonAPI.Migrations
{
    [DbContext(typeof(PokemonContext))]
    partial class PokemonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ability", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int?>("abilityid")
                        .HasColumnType("int");

                    b.Property<bool>("is_hidden")
                        .HasColumnType("bit");

                    b.Property<int>("slot")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("abilityid");

                    b.ToTable("Ability");
                });

            modelBuilder.Entity("Ability2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Ability2");
                });

            modelBuilder.Entity("Form", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("PokemonId");

                    b.ToTable("Form");
                });

            modelBuilder.Entity("GameIndice", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("game_index")
                        .HasColumnType("int");

                    b.Property<int?>("versionid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("versionid");

                    b.ToTable("GameIndice");
                });

            modelBuilder.Entity("HeldItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int?>("itemid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("itemid");

                    b.ToTable("HeldItem");
                });

            modelBuilder.Entity("Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Move", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int?>("moveid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("moveid");

                    b.ToTable("Move");
                });

            modelBuilder.Entity("Move2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Move2");
                });

            modelBuilder.Entity("MoveLearnMethod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("MoveLearnMethod");
                });

            modelBuilder.Entity("PokemonAPI.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("base_experience")
                        .HasColumnType("int");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<bool>("is_default")
                        .HasColumnType("bit");

                    b.Property<string>("location_area_encounters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("order")
                        .HasColumnType("int");

                    b.Property<int?>("speciesid")
                        .HasColumnType("int");

                    b.Property<int?>("spritesid")
                        .HasColumnType("int");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("PokemonId");

                    b.HasIndex("speciesid");

                    b.HasIndex("spritesid");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("Species", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("Sprites", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("back_default")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("back_female")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("back_shiny")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("back_shiny_female")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("front_default")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("front_female")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("front_shiny")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("front_shiny_female")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sprites");
                });

            modelBuilder.Entity("Stat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("base_stat")
                        .HasColumnType("int");

                    b.Property<int>("effort")
                        .HasColumnType("int");

                    b.Property<int?>("statid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("statid");

                    b.ToTable("Stat");
                });

            modelBuilder.Entity("Stat2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Stat2");
                });

            modelBuilder.Entity("Type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("slot")
                        .HasColumnType("int");

                    b.Property<int?>("typeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("typeid");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("Type2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Type2");
                });

            modelBuilder.Entity("Version", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Version");
                });

            modelBuilder.Entity("Version2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Version2");
                });

            modelBuilder.Entity("VersionDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HeldItemid")
                        .HasColumnType("int");

                    b.Property<int>("rarity")
                        .HasColumnType("int");

                    b.Property<int?>("versionid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("HeldItemid");

                    b.HasIndex("versionid");

                    b.ToTable("VersionDetail");
                });

            modelBuilder.Entity("VersionGroup", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("VersionGroup");
                });

            modelBuilder.Entity("VersionGroupDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Moveid")
                        .HasColumnType("int");

                    b.Property<int>("level_learned_at")
                        .HasColumnType("int");

                    b.Property<int?>("move_learn_methodid")
                        .HasColumnType("int");

                    b.Property<int?>("version_groupid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Moveid");

                    b.HasIndex("move_learn_methodid");

                    b.HasIndex("version_groupid");

                    b.ToTable("VersionGroupDetail");
                });

            modelBuilder.Entity("Ability", b =>
                {
                    b.HasOne("PokemonAPI.Models.Pokemon", null)
                        .WithMany("abilities")
                        .HasForeignKey("PokemonId");

                    b.HasOne("Ability2", "ability")
                        .WithMany()
                        .HasForeignKey("abilityid");
                });

            modelBuilder.Entity("Form", b =>
                {
                    b.HasOne("PokemonAPI.Models.Pokemon", null)
                        .WithMany("forms")
                        .HasForeignKey("PokemonId");
                });

            modelBuilder.Entity("GameIndice", b =>
                {
                    b.HasOne("PokemonAPI.Models.Pokemon", null)
                        .WithMany("game_indices")
                        .HasForeignKey("PokemonId");

                    b.HasOne("Version", "version")
                        .WithMany()
                        .HasForeignKey("versionid");
                });

            modelBuilder.Entity("HeldItem", b =>
                {
                    b.HasOne("PokemonAPI.Models.Pokemon", null)
                        .WithMany("held_items")
                        .HasForeignKey("PokemonId");

                    b.HasOne("Item", "item")
                        .WithMany()
                        .HasForeignKey("itemid");
                });

            modelBuilder.Entity("Move", b =>
                {
                    b.HasOne("PokemonAPI.Models.Pokemon", null)
                        .WithMany("moves")
                        .HasForeignKey("PokemonId");

                    b.HasOne("Move2", "move")
                        .WithMany()
                        .HasForeignKey("moveid");
                });

            modelBuilder.Entity("PokemonAPI.Models.Pokemon", b =>
                {
                    b.HasOne("Species", "species")
                        .WithMany()
                        .HasForeignKey("speciesid");

                    b.HasOne("Sprites", "sprites")
                        .WithMany()
                        .HasForeignKey("spritesid");
                });

            modelBuilder.Entity("Stat", b =>
                {
                    b.HasOne("PokemonAPI.Models.Pokemon", null)
                        .WithMany("stats")
                        .HasForeignKey("PokemonId");

                    b.HasOne("Stat2", "stat")
                        .WithMany()
                        .HasForeignKey("statid");
                });

            modelBuilder.Entity("Type", b =>
                {
                    b.HasOne("PokemonAPI.Models.Pokemon", null)
                        .WithMany("types")
                        .HasForeignKey("PokemonId");

                    b.HasOne("Type2", "type")
                        .WithMany()
                        .HasForeignKey("typeid");
                });

            modelBuilder.Entity("VersionDetail", b =>
                {
                    b.HasOne("HeldItem", null)
                        .WithMany("version_details")
                        .HasForeignKey("HeldItemid");

                    b.HasOne("Version2", "version")
                        .WithMany()
                        .HasForeignKey("versionid");
                });

            modelBuilder.Entity("VersionGroupDetail", b =>
                {
                    b.HasOne("Move", null)
                        .WithMany("version_group_details")
                        .HasForeignKey("Moveid");

                    b.HasOne("MoveLearnMethod", "move_learn_method")
                        .WithMany()
                        .HasForeignKey("move_learn_methodid");

                    b.HasOne("VersionGroup", "version_group")
                        .WithMany()
                        .HasForeignKey("version_groupid");
                });
#pragma warning restore 612, 618
        }
    }
}
