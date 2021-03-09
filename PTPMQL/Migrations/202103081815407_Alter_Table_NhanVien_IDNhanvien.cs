namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_NhanVien_IDNhanvien : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NhanViens");
            AlterColumn("dbo.NhanViens", "IDNhanvien", c => c.String(nullable: false, maxLength: 15));
            AddPrimaryKey("dbo.NhanViens", "IDNhanvien");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.NhanViens");
            AlterColumn("dbo.NhanViens", "IDNhanvien", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.NhanViens", "IDNhanvien");
        }
    }
}
