using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLAB1.Pages
{
    public class IndexModel : PageModel
    {
       
        public int EmployeeID { get; set; }
        [Required,FromQuery(Name = "Name")]
       
        public string Name { get; set; }
        [Required,FromQuery(Name = "Department")]
        public string Department { get; set; }
        [Required,FromQuery(Name = "Designation")]
        public string Designation { get; set; }
        public string Result { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Result = Name + " " + Department + " " + Designation;
            //return Result;
        }
    }
}
