using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using HoangThiHaiAnh883.Models;

namespace HoangThiHaiAnh883.Models
{
    public class CompamyHthA883 
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã")]
        [Required]
        public string CompanyId { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        [Required]
        public string CompanyName { get; set; }
    }
}