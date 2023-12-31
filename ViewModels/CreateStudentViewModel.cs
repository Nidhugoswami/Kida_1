using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kida_1.ViewModels
{
    public class CreateStudentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }

        public IList<SelectListItem> Course { get; set; }
    }
}
