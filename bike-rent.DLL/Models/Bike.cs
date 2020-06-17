using bike_rent.DLL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bike_rent.DLL.Models
{
     public class Bike:BaseEntity
    {
        [Required(ErrorMessage = "Bike's name is required")]
        [Display(Name = "Bike Name")]
        [StringLength(100, ErrorMessage = "Bike's name is too long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "It is required")]
        [Display(Name = "Bike Type")]
        public TypeEnum Type { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        [DataType(DataType.Currency, ErrorMessage = "Price format is not valid ")]
        public int Price { get; set; }
        [Required(ErrorMessage = "It is required")]
        [Display(Name = "Status")]
        public StatusEnum Status { get; set; }
    }
}
