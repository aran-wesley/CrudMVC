namespace CrudMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoverObriagatoriedadeDoEmail : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aluno", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aluno", "Email", c => c.String(nullable: false));
        }
    }
}
