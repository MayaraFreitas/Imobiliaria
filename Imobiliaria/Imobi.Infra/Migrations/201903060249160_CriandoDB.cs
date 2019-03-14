namespace Imobi.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome_PrimeiroNome = c.String(maxLength: 100, unicode: false),
                        Nome_SobreNome = c.String(maxLength: 100, unicode: false),
                        Apelido = c.String(maxLength: 100, unicode: false),
                        Email_Endereco = c.String(maxLength: 100, unicode: false),
                        Senha = c.String(maxLength: 100, unicode: false),
                        Status = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
