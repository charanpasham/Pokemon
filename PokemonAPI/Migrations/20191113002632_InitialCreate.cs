using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability2",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Move2",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MoveLearnMethod",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveLearnMethod", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sprites",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    back_default = table.Column<string>(nullable: true),
                    back_female = table.Column<string>(nullable: true),
                    back_shiny = table.Column<string>(nullable: true),
                    back_shiny_female = table.Column<string>(nullable: true),
                    front_default = table.Column<string>(nullable: true),
                    front_female = table.Column<string>(nullable: true),
                    front_shiny = table.Column<string>(nullable: true),
                    front_shiny_female = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprites", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stat2",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Type2",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Version2",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VersionGroup",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PokemonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    base_experience = table.Column<int>(nullable: false),
                    height = table.Column<int>(nullable: false),
                    id = table.Column<int>(nullable: false),
                    is_default = table.Column<bool>(nullable: false),
                    location_area_encounters = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    order = table.Column<int>(nullable: false),
                    speciesid = table.Column<int>(nullable: true),
                    spritesid = table.Column<int>(nullable: true),
                    weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_Pokemon_Species_speciesid",
                        column: x => x.speciesid,
                        principalTable: "Species",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemon_Sprites_spritesid",
                        column: x => x.spritesid,
                        principalTable: "Sprites",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    abilityid = table.Column<int>(nullable: true),
                    is_hidden = table.Column<bool>(nullable: false),
                    slot = table.Column<int>(nullable: false),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ability_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ability_Ability2_abilityid",
                        column: x => x.abilityid,
                        principalTable: "Ability2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.id);
                    table.ForeignKey(
                        name: "FK_Form_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameIndice",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    game_index = table.Column<int>(nullable: false),
                    versionid = table.Column<int>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameIndice", x => x.id);
                    table.ForeignKey(
                        name: "FK_GameIndice_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameIndice_Version_versionid",
                        column: x => x.versionid,
                        principalTable: "Version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeldItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemid = table.Column<int>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeldItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_HeldItem_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeldItem_Item_itemid",
                        column: x => x.itemid,
                        principalTable: "Item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moveid = table.Column<int>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.id);
                    table.ForeignKey(
                        name: "FK_Move_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Move_Move2_moveid",
                        column: x => x.moveid,
                        principalTable: "Move2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    base_stat = table.Column<int>(nullable: false),
                    effort = table.Column<int>(nullable: false),
                    statid = table.Column<int>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Stat_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stat_Stat2_statid",
                        column: x => x.statid,
                        principalTable: "Stat2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    slot = table.Column<int>(nullable: false),
                    typeid = table.Column<int>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.id);
                    table.ForeignKey(
                        name: "FK_Type_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Type_Type2_typeid",
                        column: x => x.typeid,
                        principalTable: "Type2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VersionDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rarity = table.Column<int>(nullable: false),
                    versionid = table.Column<int>(nullable: true),
                    HeldItemid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_VersionDetail_HeldItem_HeldItemid",
                        column: x => x.HeldItemid,
                        principalTable: "HeldItem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VersionDetail_Version2_versionid",
                        column: x => x.versionid,
                        principalTable: "Version2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VersionGroupDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    level_learned_at = table.Column<int>(nullable: false),
                    move_learn_methodid = table.Column<int>(nullable: true),
                    version_groupid = table.Column<int>(nullable: true),
                    Moveid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionGroupDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_VersionGroupDetail_Move_Moveid",
                        column: x => x.Moveid,
                        principalTable: "Move",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VersionGroupDetail_MoveLearnMethod_move_learn_methodid",
                        column: x => x.move_learn_methodid,
                        principalTable: "MoveLearnMethod",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VersionGroupDetail_VersionGroup_version_groupid",
                        column: x => x.version_groupid,
                        principalTable: "VersionGroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_PokemonId",
                table: "Ability",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_abilityid",
                table: "Ability",
                column: "abilityid");

            migrationBuilder.CreateIndex(
                name: "IX_Form_PokemonId",
                table: "Form",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_GameIndice_PokemonId",
                table: "GameIndice",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_GameIndice_versionid",
                table: "GameIndice",
                column: "versionid");

            migrationBuilder.CreateIndex(
                name: "IX_HeldItem_PokemonId",
                table: "HeldItem",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_HeldItem_itemid",
                table: "HeldItem",
                column: "itemid");

            migrationBuilder.CreateIndex(
                name: "IX_Move_PokemonId",
                table: "Move",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Move_moveid",
                table: "Move",
                column: "moveid");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_speciesid",
                table: "Pokemon",
                column: "speciesid");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_spritesid",
                table: "Pokemon",
                column: "spritesid");

            migrationBuilder.CreateIndex(
                name: "IX_Stat_PokemonId",
                table: "Stat",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Stat_statid",
                table: "Stat",
                column: "statid");

            migrationBuilder.CreateIndex(
                name: "IX_Type_PokemonId",
                table: "Type",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_typeid",
                table: "Type",
                column: "typeid");

            migrationBuilder.CreateIndex(
                name: "IX_VersionDetail_HeldItemid",
                table: "VersionDetail",
                column: "HeldItemid");

            migrationBuilder.CreateIndex(
                name: "IX_VersionDetail_versionid",
                table: "VersionDetail",
                column: "versionid");

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroupDetail_Moveid",
                table: "VersionGroupDetail",
                column: "Moveid");

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroupDetail_move_learn_methodid",
                table: "VersionGroupDetail",
                column: "move_learn_methodid");

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroupDetail_version_groupid",
                table: "VersionGroupDetail",
                column: "version_groupid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "GameIndice");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "VersionDetail");

            migrationBuilder.DropTable(
                name: "VersionGroupDetail");

            migrationBuilder.DropTable(
                name: "Ability2");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "Stat2");

            migrationBuilder.DropTable(
                name: "Type2");

            migrationBuilder.DropTable(
                name: "HeldItem");

            migrationBuilder.DropTable(
                name: "Version2");

            migrationBuilder.DropTable(
                name: "Move");

            migrationBuilder.DropTable(
                name: "MoveLearnMethod");

            migrationBuilder.DropTable(
                name: "VersionGroup");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Move2");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Sprites");
        }
    }
}
