
using System.Globalization;

namespace Task4_FileCheck
{
    public class Good
    {
        private string? _name;
        private decimal _price;

        public Good(string name, decimal price)
        {
            _name = name;

            if (price > 0.0m) _price = price;
            else _price = 0.0m;
        }
        public string Name { get { return _name!; } }
        public decimal Price { get { return _price; } }
        public decimal Usd
        {
            get { return _price / 27.98m; }
        }
        public decimal Euro
        {
            get { return _price / 31.97m; }
        }
        public decimal Rub
        {
            get { return _price / 0.31m; }
        }

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format))
                format = "G";

            if (provider == null)
                provider = CultureInfo.CurrentCulture;

            switch (format.ToLowerInvariant())
            {
                case "Ua":
                    return _price.ToString("F2", provider) + " Hr";
                case "Usd":
                    return Usd.ToString("F2", provider) + " USD";
                default:
                    throw new FormatException();
            }
        }
    }
}
