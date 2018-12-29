using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{
    public class RemoveItemViewModel
    {
        [Required]
        public double NewElement2 { get; set; }
        public List<Shape> Remlist { get; set; }
    }
}
