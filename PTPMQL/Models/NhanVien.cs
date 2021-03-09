

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        [StringLength(15)]
        public string IDNhanvien { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string QueQuan { get; set; }
    }
}