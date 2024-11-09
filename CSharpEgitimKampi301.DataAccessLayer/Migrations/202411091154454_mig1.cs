namespace CSharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration   // Ben senin migrationunu DbMigration dana alacağım 
    {
        public override void Up()   // Eğer sen update yaparsan 
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false)); 
            // customers tabloun içine customerstatus adında sütun eklicem. Busütun boolean olacak ve nullenablesi false olacak yani boş geçilemez olacak.
        }
        
        public override void Down()   // eğerki sen işlemi geri almak istersen
        {
            DropColumn("dbo.Customers", "CustomerStatus");   //sen bu migrationdan vazgeçersen ben bu eklediğimi sileceğim. 
        }
    }
}
