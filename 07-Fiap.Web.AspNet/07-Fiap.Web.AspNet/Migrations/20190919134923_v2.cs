using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _07Fiap.Web.AspNet.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TCondominio",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SindicoId",
                table: "TCondominio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Construtoras",
                columns: table => new
                {
                    ConstrutoraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Construtoras", x => x.ConstrutoraId);
                });

            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    ImovelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(nullable: true),
                    AreaUtil = table.Column<float>(nullable: false),
                    CondominioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.ImovelId);
                    table.ForeignKey(
                        name: "FK_Imoveis_TCondominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "TCondominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sindicos",
                columns: table => new
                {
                    SindicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sindicos", x => x.SindicoId);
                });

            migrationBuilder.CreateTable(
                name: "CondominioConstrutora",
                columns: table => new
                {
                    CondominioId = table.Column<int>(nullable: false),
                    ConstrutoraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondominioConstrutora", x => new { x.CondominioId, x.ConstrutoraId });
                    table.ForeignKey(
                        name: "FK_CondominioConstrutora_TCondominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "TCondominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CondominioConstrutora_Construtoras_ConstrutoraId",
                        column: x => x.ConstrutoraId,
                        principalTable: "Construtoras",
                        principalColumn: "ConstrutoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TCondominio_SindicoId",
                table: "TCondominio",
                column: "SindicoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondominioConstrutora_ConstrutoraId",
                table: "CondominioConstrutora",
                column: "ConstrutoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_CondominioId",
                table: "Imoveis",
                column: "CondominioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TCondominio_Sindicos_SindicoId",
                table: "TCondominio",
                column: "SindicoId",
                principalTable: "Sindicos",
                principalColumn: "SindicoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TCondominio_Sindicos_SindicoId",
                table: "TCondominio");

            migrationBuilder.DropTable(
                name: "CondominioConstrutora");

            migrationBuilder.DropTable(
                name: "Imoveis");

            migrationBuilder.DropTable(
                name: "Sindicos");

            migrationBuilder.DropTable(
                name: "Construtoras");

            migrationBuilder.DropIndex(
                name: "IX_TCondominio_SindicoId",
                table: "TCondominio");

            migrationBuilder.DropColumn(
                name: "SindicoId",
                table: "TCondominio");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TCondominio",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }
    }
}
