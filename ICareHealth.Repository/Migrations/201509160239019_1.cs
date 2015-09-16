namespace ICareHealth.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBPlan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        Save = c.DateTime(nullable: false),
                        Update = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TBUser",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                        BirthYear = c.Int(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 1, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        Save = c.DateTime(nullable: false),
                        Update = c.DateTime(nullable: false),
                        Plan_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TBPlan", t => t.Plan_Id, cascadeDelete: true)
                .Index(t => t.Plan_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBUser", "Plan_Id", "dbo.TBPlan");
            DropIndex("dbo.TBUser", new[] { "Plan_Id" });
            DropTable("dbo.TBUser");
            DropTable("dbo.TBPlan");
        }
    }
}
