﻿namespace ShoeStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addElgantShoesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ElegantShoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Gender = c.String(),
                        HasHeel = c.Boolean(nullable: false),
                        HasInStock = c.Boolean(nullable: false),
                        Size = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ElegantShoes");
        }
    }
}
