using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imobi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vistoria",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataVistoria = table.Column<DateTime>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    IdSolicitacao = table.Column<long>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    Energia = table.Column<bool>(nullable: false),
                    Agua = table.Column<bool>(nullable: false),
                    Gas = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vistoria", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vistoria");
        }
    }
}
