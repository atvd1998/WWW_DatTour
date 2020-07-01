using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourCore.Models.Commands
{
    public class InsertTourCommand
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string NameTour { get; set; }
        [Required]
        public int? Day { get; set; }
        [Required]
        public int? Night { get; set; }
        [Required]
        public decimal? Cost { get; set; }
        [Required]
        public IFormFile Picture { get; set; }
        [Required]
        public bool CheckNational { get; set; }
        [Required]
        public int Check { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
