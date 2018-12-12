using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetMarketWEB.Data.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contragents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Oblast = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contragents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cpus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Architecture = table.Column<string>(nullable: true),
                    Cores = table.Column<string>(nullable: true),
                    Chastota = table.Column<string>(nullable: true),
                    KESHL1 = table.Column<string>(nullable: true),
                    KESHL2 = table.Column<string>(nullable: true),
                    KESHL3 = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    RAM = table.Column<string>(nullable: true),
                    TDP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "docForPains",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Organization = table.Column<string>(nullable: true),
                    Contragent = table.Column<string>(nullable: true),
                    DataLoad = table.Column<string>(nullable: true),
                    DataLoad1 = table.Column<string>(nullable: true),
                    Dataload2 = table.Column<string>(nullable: true),
                    Dataload3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_docForPains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dogovors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dogovors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "grafics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    GraphicsCore = table.Column<string>(nullable: true),
                    Cores = table.Column<string>(nullable: true),
                    Herts = table.Column<string>(nullable: true),
                    VRAM = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grafics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "oblasts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oblasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organisationProfessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CodeKP = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisationProfessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firm = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    RAM = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Oblast = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "streets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    NameStreen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_streets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tablets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    RAM = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    Resolution = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tivis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firm = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tivis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "zakazPokupatelyas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Organization = table.Column<string>(nullable: true),
                    Contragent = table.Column<string>(nullable: true),
                    Sklad = table.Column<string>(nullable: true),
                    Ysluga = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zakazPokupatelyas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contragents");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "cpus");

            migrationBuilder.DropTable(
                name: "docForPains");

            migrationBuilder.DropTable(
                name: "dogovors");

            migrationBuilder.DropTable(
                name: "grafics");

            migrationBuilder.DropTable(
                name: "oblasts");

            migrationBuilder.DropTable(
                name: "organisationProfessions");

            migrationBuilder.DropTable(
                name: "organisations");

            migrationBuilder.DropTable(
                name: "phones");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "streets");

            migrationBuilder.DropTable(
                name: "tablets");

            migrationBuilder.DropTable(
                name: "tivis");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "zakazPokupatelyas");
        }
    }
}
