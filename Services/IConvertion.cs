using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Converter.Services
{
    public interface IConvertion
    {
        public string DoConversion(string ConvertFrom, string ConvertTo, double InputValue);
    }
}
