using System;
using Imobiliaria.Helpers;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imobiliaria.Data.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            #region Tabelas

            #region Geradas

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserType = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            #endregion

            #region Tabela Endereco
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Rua = table.Column<string>(maxLength: 256, nullable: false),
                    Cep = table.Column<string>(maxLength: 10, nullable: false),
                    Bairro = table.Column<string>(maxLength: 256, nullable: false),
                    Cidade = table.Column<string>(maxLength: 256, nullable: false),
                    Estado = table.Column<string>(maxLength: 2, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });


            #endregion Tabela Endereco

            #region Tabela Empresa
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 255, nullable: false),
                    NomeFantasia = table.Column<string>(maxLength: 255, nullable: true),
                    Documento = table.Column<string>(maxLength: 45, nullable: false),
                    InscricaoEstadual = table.Column<string>(maxLength: 45, nullable: false),
                    InscricaoMunicipal = table.Column<string>(maxLength: 45, nullable: true),
                    Email = table.Column<string>(maxLength: 45, nullable: true),
                    Site = table.Column<string>(maxLength: 100, nullable: true),
                    Telefone = table.Column<string>(maxLength: 45, nullable: false),
                    TelefoneCelular = table.Column<string>(maxLength: 45, nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdEndereco = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                }
            );
            #endregion

            #region Cliente
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Documento = table.Column<string>(maxLength: 45, nullable: false),
                    Cargo = table.Column<byte>(nullable: false),
                    Telefone = table.Column<string>(maxLength: 45, nullable: false),
                    Celular = table.Column<string>(maxLength: 45, nullable: false),
                    Whatsapp = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Sexo = table.Column<byte>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    IdEndereco = table.Column<int>(nullable: false),
                    IdEmpresa = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cliente_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                }
            );
            #endregion

            #region Tabela Imovel
            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Idade = table.Column<long>(nullable: false),
                    Seguro = table.Column<bool>(nullable: false),
                    IdEndereco = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imovel_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imovel_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                }
            );
            #endregion #region Tabela Imovel

            #region Solicitacao
            migrationBuilder.CreateTable(
               name: "Solicitacao",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   DataSolicitacao = table.Column<DateTime>(nullable: false),
                   DataVistoria = table.Column<DateTime>(nullable: true),
                   Status = table.Column<byte>(nullable: false),
                   IdVistoriador = table.Column<string>(maxLength: 450, nullable: false),
                   IdSolicitador = table.Column<string>(maxLength: 450, nullable: false),
                   IdImovel = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Solicitacao", x => x.Id);
                   table.ForeignKey(
                       name: "FK_Solicitacao_AspNetUsers_IdVistoriador",
                       column: x => x.IdVistoriador,
                       principalTable: "AspNetUsers",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.NoAction);
                   table.ForeignKey(
                       name: "FK_Solicitacao_AspNetUsers_IdSolicitador",
                       column: x => x.IdSolicitador,
                       principalTable: "AspNetUsers",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.NoAction);
                   table.ForeignKey(
                       name: "FK_Solicitacao_Imovel_IdEndereco",
                       column: x => x.IdImovel,
                       principalTable: "Imovel",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.NoAction);
               }
            );
            #endregion Solicitacao

            #region Log Soliciacao
            migrationBuilder.CreateTable(
               name: "LogSolicitacao",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   DataAtualizacao = table.Column<DateTime>(nullable: false),
                   DataVistoria = table.Column<DateTime>(nullable: false),
                   Descricao = table.Column<string>(maxLength: 8000, nullable: false),
                   IdVistoriador = table.Column<string>(maxLength: 450, nullable: false),
                   IdSolicitador = table.Column<string>(maxLength: 450, nullable: false),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_LogSolicitacao", x => x.Id);
                   table.ForeignKey(
                       name: "FK_LogSolicitacao_AspNetUsers_IdVistoriador",
                       column: x => x.IdVistoriador,
                       principalTable: "AspNetUsers",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.NoAction);
                   table.ForeignKey(
                       name: "FK_LogSolicitacao_AspNetUsers_IdSolicitador",
                       column: x => x.IdSolicitador,
                       principalTable: "AspNetUsers",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.NoAction);
               }
            );
            #endregion

            #region Vistoria
            migrationBuilder.CreateTable(
               name: "Vistoria",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   DataInicio = table.Column<DateTime>(nullable: true),
                   DataFim = table.Column<DateTime>(nullable: true),
                   Status = table.Column<byte>(nullable: false),
                   IdSolicitacao = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Vistoria", x => x.Id);
                   table.ForeignKey(
                       name: "FK_Vistoria_Solicitacao_IdSolicitacao",
                       column: x => x.IdSolicitacao,
                       principalTable: "Solicitacao",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.NoAction);
               }
            );
            #endregion

            #region Medicao
            migrationBuilder.CreateTable(
               name: "Medicao",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   Agua = table.Column<string>(nullable: false),
                   Energia = table.Column<string>(nullable: false),
                   Extintor = table.Column<byte>(nullable: false),
                   GasEncanado = table.Column<byte>(nullable: false),
                   Ativo = table.Column<bool>(nullable: false),
                   IdVistoria = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Medicao", x => x.Id);
                   table.ForeignKey(
                       name: "FK_Medicao_Vistoria_IdVistoria",
                       column: x => x.IdVistoria,
                       principalTable: "Vistoria",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.NoAction);
               }
            );
            #endregion Medicao

            #region Comodo
            migrationBuilder.CreateTable(
               name: "Comodo",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   Nome = table.Column<string>(maxLength: 200, nullable: false),
                   Imagem = table.Column<byte[]>(nullable: true),
                   Ativo = table.Column<bool>(nullable: false),
                   CorTeto = table.Column<byte>(nullable: false),
                   CorParede = table.Column<byte>(nullable: false),
                   IdVistoria = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Comodo", x => x.Id);
                   table.ForeignKey(
                       name: "FK_Comodo_Vistoria_IdVistoria",
                       column: x => x.IdVistoria,
                       principalTable: "Vistoria",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               }
            );
            #endregion Comodo

            #region Nota
            migrationBuilder.CreateTable(
               name: "Nota",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   Titulo = table.Column<string>(maxLength: 200, nullable: false),
                   Descricao = table.Column<string>(maxLength: 8000, nullable: false),
                   Imagem = table.Column<byte[]>(nullable: true),
                   IdComodo = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Nota", x => x.Id);
                   table.ForeignKey(
                       name: "FK_Nota_Comodo_IdComodo",
                       column: x => x.IdComodo,
                       principalTable: "Comodo",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               }
            );
            #endregion Nota

            #endregion

            #region Index

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            #endregion

            #region Popular banco
            /*
            #region Endere?o

            // Endereco da empresa
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Estado", "Cidade", "Cep", "Bairro", "Rua", "Numero", "Ativo" },
                values: new object[] { 1, "PA", "Bel?m", "66020-690", "Cidade Velha", "Passagem Maria Lu?sa", "654", true }
            );

            // Endereco do cliente 1
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Estado", "Cidade", "Cep", "Bairro", "Rua", "Numero", "Ativo" },
                values: new object[] { 2, "DF", "Bras?lia", "Santa Maria", "72501-103", "Vila Carlos Nobre", "987", true }
            );

            // Endereco do cliente 2
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Estado", "Cidade", "Cep", "Bairro", "Rua", "Numero", "Ativo" },
                values: new object[] { 3, "SP", "Sumare", "13175-380", "Altos de Sumar?", "Rua Xavier de Sampaio", "999", true }
            );

            // Endereco do im?vel 1 
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Estado", "Cidade", "Cep", "Bairro", "Rua", "Numero", "Ativo" },
                values: new object[] { 4, "AC", "Rio Branco", "69304-550", "JD. Santa Candida", "Rua dos Bobos", "0", true }
            );

            // Endereco do im?vel 2
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Estado", "Cidade", "Cep", "Bairro", "Rua", "Numero", "Ativo" },
                values: new object[] { 5, "SP", "Campinas", "13080-270", "Villa Lobos", "Pedro Vieira de Souza", "144", true }
            );

            // Endereco do im?vel 3
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Estado", "Cidade", "Cep", "Bairro", "Rua", "Numero", "Ativo" },
                values: new object[] { 6, "SP", "V?rzea Grande", "78145-470", "S?o Sim?o", "Rua Mato Grosso", "996", true }
            );

            #endregion

            #region Empresa
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "NomeFantasia", "Documento", "InscricaoEstadual", "InscricaoMunicipal", "Email", "Site", "Telefone", "TelefoneCelular", "Ativo", "IdEndereco" },
                values: new object[] { 1, "HidroleoLtda", "45142110000126", "085648784071", "hidroleo@gmail.com", "www.hidroleo.com.br", "1938836523", "19998563214", 1, 1 }
            );
            #endregion

            #region Cliente

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Nome", "Documento", "Cargo", "Telefone", "Celular", "Whatsapp", "Ativo", "Email", "Sexo", "DataNascimento", "IdEndereco", "IdEmpresa" },
                values: new object[] { 1, "Levi Thales Raul Caldeira", "85916306539", Constants.Cargo.Cliente, "1938837799", "19993256748", Constants.TemWhatsapp.Sim, Constants.StatusAtivo.Ativo, "levithales@gmail.com", Constants.Sexo.Masculino, new DateTime(1980, 10, 11), 2, 1 }
            );

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Nome", "Documento", "Cargo", "Telefone", "Celular", "Whatsapp", "Ativo", "Email", "Sexo", "DataNascimento", "IdEndereco", "IdEmpresa" },
                values: new object[] { 2, "Maya Sueli da Luz", "15819604091", Constants.Cargo.Cliente, "1938386262", "19999366897", Constants.TemWhatsapp.Nao, Constants.StatusAtivo.Ativo, "MayaSueli@hotmail.com", Constants.Sexo.Feminino, new DateTime(1977, 03, 07), 3, 1 }
            );

            #endregion

            #region Imovel

            migrationBuilder.InsertData(
                table: "Imovel",
                columns: new[] { "(Id", "Area", "Ativo", "Idade", "Seguro", "IdEndereco", "IdCliente" },
                values: new object[] { 1, 80, Constants.StatusAtivo.Ativo, 20, Constants.SimNao.Sim, 4, 1 }
            );

            migrationBuilder.InsertData(
                table: "Imovel",
                columns: new[] { "(Id", "Area", "Ativo", "Idade", "Seguro", "IdEndereco", "IdCliente" },
                values: new object[] { 2, 90, Constants.StatusAtivo.Ativo, 3, Constants.SimNao.Nao, 5, 1 }
            );

            migrationBuilder.InsertData(
                table: "Imovel",
                columns: new[] { "(Id", "Area", "Ativo", "Idade", "Seguro", "IdEndereco", "IdCliente" },
                values: new object[] { 3, 95, Constants.StatusAtivo.Ativo, 6, Constants.SimNao.Nao, 6, 1 }
            );
            #endregion

            /*
             * migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] {"",""},
                values: new object[] {}
            );
            */

            #endregion
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}