using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eventos.AcessoADados.Migrations
{
    public partial class AdicionadoTableEventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IdEvento = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeEvento = table.Column<string>(nullable: false),
                    DataEvento = table.Column<DateTime>(nullable: false),
                    LocalEvento = table.Column<string>(nullable: false),
                    HorarioInicio = table.Column<DateTime>(nullable: true),
                    HorarioFinal = table.Column<DateTime>(nullable: false),
                    OpenBar = table.Column<Boolean>(nullable: false),
                    QuantidadeAmbientes = table.Column<int>(nullable: true),
                    FaixaEtaria = table.Column<string>(nullable: false),
                    MaximoIngressos = table.Column<int>(nullable: false),
                    IngressosVendidos = table.Column<int>(nullable: true),
                    QuantidadeIngressos = table.Column<string>(nullable: false)
                },

        constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IdEvento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
