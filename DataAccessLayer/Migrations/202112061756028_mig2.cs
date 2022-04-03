﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterSurname", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterSSurname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterSSurname", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterSurname");
        }
    }
}
