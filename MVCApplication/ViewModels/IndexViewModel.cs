using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{
    public class IndexViewModel
    {

        [Required]
        public double sidelength { get; set; }

    }

}
