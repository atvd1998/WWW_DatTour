using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;

namespace TourCore.Models.ViewModels
{
    public class TourViewModel
    {
        public int Id { get; set; }
        [DisplayName("Mã Tour")]
        [Required]
        public string Code { get; set; }
        [DisplayName("Tên Tour")]
        [Required]
        public string NameTour { get; set; }
        [DisplayName("Ngày")]
        [Required]
        public int? Day { get; set; }
        [DisplayName("Đêm")]
        [Required]
        public int? Night { get; set; }
        [DisplayName("Giá Tiền")]
        [Required]
        public decimal? Cost { get; set; }
        [DisplayName("Hình ảnh")]
        [Required]
        public string Picture { get; set; }
        public bool TopHot { get; set; }
        public bool NewTour { get; set; }
        public decimal? Discount { get; set; }
        public int NumberBooking { get; set; }
        public string Description { get; set; }
        public bool Domestic { get; set; }
        public bool National { get; set; }
        [DisplayName("Số lượng")]
        public int? Quantity { get; set; }
        public string Title { get; set; }
    }
}
