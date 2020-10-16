using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbConsCoreEf.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "A001s",
                columns: table => new
                {
                    A = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "alphPtBrs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    A = table.Column<string>(nullable: true),
                    B = table.Column<string>(nullable: true),
                    C = table.Column<string>(nullable: true),
                    D = table.Column<string>(nullable: true),
                    E = table.Column<string>(nullable: true),
                    F = table.Column<string>(nullable: true),
                    G = table.Column<string>(nullable: true),
                    H = table.Column<string>(nullable: true),
                    I = table.Column<string>(nullable: true),
                    J = table.Column<string>(nullable: true),
                    K = table.Column<string>(nullable: true),
                    L = table.Column<string>(nullable: true),
                    M = table.Column<string>(nullable: true),
                    N = table.Column<string>(nullable: true),
                    O = table.Column<string>(nullable: true),
                    P = table.Column<string>(nullable: true),
                    Q = table.Column<string>(nullable: true),
                    R = table.Column<string>(nullable: true),
                    S = table.Column<string>(nullable: true),
                    T = table.Column<string>(nullable: true),
                    U = table.Column<string>(nullable: true),
                    V = table.Column<string>(nullable: true),
                    W = table.Column<string>(nullable: true),
                    X = table.Column<string>(nullable: true),
                    Y = table.Column<string>(nullable: true),
                    Z = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alphPtBrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    B = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "C001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    C = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    D = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "E001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    E = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    F = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "G001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    G = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_G001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    H = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    I = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "J001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    J = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_J001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "K001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    K = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "L001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    L = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    M = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "N001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    N = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_N001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "O001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    O = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_O001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    P = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Q001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Q = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Q001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    R = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "S001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    T = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "U001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    U = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_U001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "V001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    V = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "W001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    W = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_W001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "X001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    X = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Y001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Y = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Y001s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Z001s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Z = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Z001s", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A001s");

            migrationBuilder.DropTable(
                name: "alphPtBrs");

            migrationBuilder.DropTable(
                name: "B001s");

            migrationBuilder.DropTable(
                name: "C001s");

            migrationBuilder.DropTable(
                name: "D001s");

            migrationBuilder.DropTable(
                name: "E001s");

            migrationBuilder.DropTable(
                name: "F001s");

            migrationBuilder.DropTable(
                name: "G001s");

            migrationBuilder.DropTable(
                name: "H001s");

            migrationBuilder.DropTable(
                name: "I001s");

            migrationBuilder.DropTable(
                name: "J001s");

            migrationBuilder.DropTable(
                name: "K001s");

            migrationBuilder.DropTable(
                name: "L001s");

            migrationBuilder.DropTable(
                name: "M001s");

            migrationBuilder.DropTable(
                name: "N001s");

            migrationBuilder.DropTable(
                name: "O001s");

            migrationBuilder.DropTable(
                name: "P001s");

            migrationBuilder.DropTable(
                name: "Q001s");

            migrationBuilder.DropTable(
                name: "R001s");

            migrationBuilder.DropTable(
                name: "S001s");

            migrationBuilder.DropTable(
                name: "T001s");

            migrationBuilder.DropTable(
                name: "U001s");

            migrationBuilder.DropTable(
                name: "V001s");

            migrationBuilder.DropTable(
                name: "W001s");

            migrationBuilder.DropTable(
                name: "X001s");

            migrationBuilder.DropTable(
                name: "Y001s");

            migrationBuilder.DropTable(
                name: "Z001s");
        }
    }
}
