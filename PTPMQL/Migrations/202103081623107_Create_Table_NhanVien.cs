namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        IDNhanvien = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        ChucVu = c.String(),
                        QueQuan = c.String(),
                    })
                .PrimaryKey(t => t.IDNhanvien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
