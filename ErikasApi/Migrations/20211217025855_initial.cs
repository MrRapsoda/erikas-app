using Microsoft.EntityFrameworkCore.Migrations;

namespace ErikasApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accesorioss",
                columns: table => new
                {
                    idAccesorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoAccesorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accesorioss", x => x.idAccesorio);
                });

            migrationBuilder.CreateTable(
                name: "Trajes2",
                columns: table => new
                {
                    idTraje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ajuste = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Talla = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trajes2", x => x.idTraje);
                });

            migrationBuilder.CreateTable(
                name: "Vestido",
                columns: table => new
                {
                    idVestidos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estilo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    talla = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vestido", x => x.idVestidos);
                });

            migrationBuilder.CreateTable(
                name: "VQuinceanos",
                columns: table => new
                {
                    idQuinceanos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ajuste = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    talla = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VQuinceanos", x => x.idQuinceanos);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accesorioss");

            migrationBuilder.DropTable(
                name: "Trajes2");

            migrationBuilder.DropTable(
                name: "Vestido");

            migrationBuilder.DropTable(
                name: "VQuinceanos");
        }
    }
}
