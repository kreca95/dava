using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Models
{
    public class HomePageViewModel
    {
        public int CategoryId { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public string Tags { get; set; }

    }
}
