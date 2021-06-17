using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebLAB1.Pages
{
    public class IntroModel : PageModel
    {
        [FromQuery(Name ="Operand1")]
        public double Operand1 { get; set; }
        [FromQuery(Name = "Operand2")]
       public double Operand2 { get; set; }
      
        public  double Result { get; set; }
        public void OnGet()
        {
            Result = Operand1 * Operand2;

        }


        public double MultiplyOperation(double x, double y)
        {
            Result = x * y;

            return Result;
        }
    }
}
