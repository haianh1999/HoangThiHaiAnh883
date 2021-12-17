using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using HoangThiHaiAnh883.Models;

namespace HoangThiHaiAnh883.Models
{
    public class HTHA0883 
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã")]
        [Required]
        public string HTHAID { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        [Required]
        public string HTHAName { get; set; }
        [Display(Name = "Giới Tính")]

        public string HTHAgender { get; set; }
    }
}