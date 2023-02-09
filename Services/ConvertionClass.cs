using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Simple_Converter.Services
{
    public class ConvertionClass: IConvertion
    {
        public string DoConversion(string ConvertFrom, string ConvertTo, double InputValue)
        {
            string result = "";
            if (ConvertFrom == "in" && ConvertTo == "in") result = $"{InputValue * 1}";
            if (ConvertFrom == "in" && ConvertTo == "ft") result = $"{InputValue * 0.0833333333}";
            if (ConvertFrom == "in" && ConvertTo == "yd") result = $"{InputValue * 0.0277777778}";
            if (ConvertFrom == "in" && ConvertTo == "mi") result = $"{InputValue * 0.0000157828}";
            if (ConvertFrom == "in" && ConvertTo == "mm") result = $"{InputValue * 25.4}";
            if (ConvertFrom == "in" && ConvertTo == "cm") result = $"{InputValue * 2.54}";
            if (ConvertFrom == "in" && ConvertTo == "m") result = $"{InputValue * 0.0254}";
            if (ConvertFrom == "in" && ConvertTo == "km") result = $"{InputValue * 0.0000254}";

            if (ConvertFrom == "ft" && ConvertTo == "in") result = $"{InputValue * 12}";
            if (ConvertFrom == "ft" && ConvertTo == "ft") result = $"{InputValue * 1}";
            if (ConvertFrom == "ft" && ConvertTo == "yd") result = $"{InputValue * 0.3333333333}";
            if (ConvertFrom == "ft" && ConvertTo == "mi") result = $"{InputValue * 0.0001893939}";
            if (ConvertFrom == "ft" && ConvertTo == "mm") result = $"{InputValue * 304.8}";
            if (ConvertFrom == "ft" && ConvertTo == "cm") result = $"{InputValue * 30.48}";
            if (ConvertFrom == "ft" && ConvertTo == "m") result = $"{InputValue * 0.3048}";
            if (ConvertFrom == "ft" && ConvertTo == "km") result = $"{InputValue * 0.0003048}";

            if (ConvertFrom == "yd" && ConvertTo == "in") result = $"{InputValue * 36}";
            if (ConvertFrom == "yd" && ConvertTo == "ft") result = $"{InputValue * 3}";
            if (ConvertFrom == "yd" && ConvertTo == "yd") result = $"{InputValue * 1}";
            if (ConvertFrom == "yd" && ConvertTo == "mi") result = $"{InputValue * 0.0005681818}";
            if (ConvertFrom == "yd" && ConvertTo == "mm") result = $"{InputValue * 914.4}";
            if (ConvertFrom == "yd" && ConvertTo == "cm") result = $"{InputValue * 91.44}";
            if (ConvertFrom == "yd" && ConvertTo == "m") result = $"{InputValue * 0.9144}";
            if (ConvertFrom == "yd" && ConvertTo == "km") result = $"{InputValue * 0.0009144}";

            if (ConvertFrom == "mi" && ConvertTo == "in") result = $"{InputValue * 1760}";
            if (ConvertFrom == "mi" && ConvertTo == "ft") result = $"{InputValue * 5280}";
            if (ConvertFrom == "mi" && ConvertTo == "yd") result = $"{InputValue * 1760}";
            if (ConvertFrom == "mi" && ConvertTo == "mi") result = $"{InputValue * 1}";
            if (ConvertFrom == "mi" && ConvertTo == "mm") result = $"{InputValue * 1609344}";
            if (ConvertFrom == "mi" && ConvertTo == "cm") result = $"{InputValue * 160934.4}";
            if (ConvertFrom == "mi" && ConvertTo == "m") result = $"{InputValue * 1609.344}";
            if (ConvertFrom == "mi" && ConvertTo == "km") result = $"{InputValue * 1.609344}";

            if (ConvertFrom == "mm" && ConvertTo == "in") result = $"{InputValue * 0.0393700787}";
            if (ConvertFrom == "mm" && ConvertTo == "ft") result = $"{InputValue * 0.0032808399}";
            if (ConvertFrom == "mm" && ConvertTo == "yd") result = $"{InputValue * 0.0010936133}";
            if (ConvertFrom == "mm" && ConvertTo == "mi") result = $"{InputValue * 6.213711922E-7}";
            if (ConvertFrom == "mm" && ConvertTo == "mm") result = $"{InputValue * 1}";
            if (ConvertFrom == "mm" && ConvertTo == "cm") result = $"{InputValue * 0.1}";
            if (ConvertFrom == "mm" && ConvertTo == "m") result = $"{InputValue * 0.001}";
            if (ConvertFrom == "mm" && ConvertTo == "km") result = $"{InputValue * 0.000001}";

            if (ConvertFrom == "cm" && ConvertTo == "in") result = $"{InputValue * 0.3937007874}";
            if (ConvertFrom == "cm" && ConvertTo == "ft") result = $"{InputValue * 0.032808399}";
            if (ConvertFrom == "cm" && ConvertTo == "yd") result = $"{InputValue * 0.010936133}";
            if (ConvertFrom == "cm" && ConvertTo == "mi") result = $"{InputValue * 0.0000062137}";
            if (ConvertFrom == "cm" && ConvertTo == "mm") result = $"{InputValue * 10}";
            if (ConvertFrom == "cm" && ConvertTo == "cm") result = $"{InputValue * 1}";
            if (ConvertFrom == "cm" && ConvertTo == "m") result = $"{InputValue * 0.01}";
            if (ConvertFrom == "cm" && ConvertTo == "km") result = $"{InputValue * 0.00001}";

            if (ConvertFrom == "m" && ConvertTo == "in") result = $"{InputValue * 39.37007874}";
            if (ConvertFrom == "m" && ConvertTo == "ft") result = $"{InputValue * 3.280839895}";
            if (ConvertFrom == "m" && ConvertTo == "yd") result = $"{InputValue * 1.0936132983}";
            if (ConvertFrom == "m" && ConvertTo == "mi") result = $"{InputValue * 0.0006213712}";
            if (ConvertFrom == "m" && ConvertTo == "mm") result = $"{InputValue * 1000}";
            if (ConvertFrom == "m" && ConvertTo == "cm") result = $"{InputValue * 100}";
            if (ConvertFrom == "m" && ConvertTo == "m") result = $"{InputValue * 1}";
            if (ConvertFrom == "m" && ConvertTo == "km") result = $"{InputValue * 0.001}";

            if (ConvertFrom == "km" && ConvertTo == "in") result = $"{InputValue * 39370.07874}";
            if (ConvertFrom == "km" && ConvertTo == "ft") result = $"{InputValue * 3280.839895}";
            if (ConvertFrom == "km" && ConvertTo == "yd") result = $"{InputValue * 1093.6132983}";
            if (ConvertFrom == "km" && ConvertTo == "mi") result = $"{InputValue * 0.6213711922}";
            if (ConvertFrom == "km" && ConvertTo == "mm") result = $"{InputValue * 1000000}";
            if (ConvertFrom == "km" && ConvertTo == "cm") result = $"{InputValue * 100000}";
            if (ConvertFrom == "km" && ConvertTo == "m") result = $"{InputValue * 1000}";
            if (ConvertFrom == "km" && ConvertTo == "km") result = $"{InputValue * 1}";
            return result;
        }
    }
}
