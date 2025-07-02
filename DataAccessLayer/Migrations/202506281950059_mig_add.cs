namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "AboutImage2", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SkillsCards",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Description = c.String(),
                        SkillName = c.String(),
                        SkillLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillID);
            
            AlterColumn("dbo.Abouts", "AboutImage2", c => c.String(maxLength: 100));
        }
    }
}
