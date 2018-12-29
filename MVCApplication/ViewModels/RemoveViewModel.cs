using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{
    public class RemoveViewModel
    {
        [Required]
        public String NewElement1 { get; set; }
        public List<Shape> TheList { get; set; }
    }
}
