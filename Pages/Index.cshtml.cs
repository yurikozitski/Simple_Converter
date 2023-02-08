using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simple_Converter.Services;

namespace Simple_Converter.Pages
{
    public class IndexModel : PageModel
    {
        public double Input { get; set; }
        public string Result { get; set; }
        ConvertionClass _convertionClass;
        public IndexModel(ConvertionClass convertionClass)
        {
            _convertionClass = convertionClass;
        }
        public IActionResult OnGet()
        {
            HttpContext.Response.Cookies.Append("ConvertFrom", "in");
            HttpContext.Response.Cookies.Append("ConvertTo", "cm");
            return Page();
        }
        public IActionResult OnPostConvert_(string ConvertFrom, string ConvertTo, double InputValue)
        {
            string result = _convertionClass.DoConversion(ConvertFrom, ConvertTo, InputValue);
            HttpContext.Response.Cookies.Append("ConvertFrom", $"{ConvertFrom}");
            HttpContext.Response.Cookies.Append("ConvertTo", $"{ConvertTo}");
            Input = InputValue;
            Result = result;
            return Page();
        }
        public IActionResult OnPostSwap()
        {
            string ConvertFromCookie = HttpContext.Request.Cookies["ConvertFrom"];
            string ConvertToCookie = HttpContext.Request.Cookies["ConvertTo"];
            HttpContext.Response.Cookies.Append("ConvertFrom", $"{ConvertToCookie}");
            HttpContext.Response.Cookies.Append("ConvertTo", $"{ConvertFromCookie}");
            return Page();
        }
    }
}
