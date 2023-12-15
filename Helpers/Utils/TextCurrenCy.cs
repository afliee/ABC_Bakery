using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Helpers.Utils
{
    internal class TextCurrency
    {
        public static string NO_DECIMAL = "{0:C}";
        public static string ONE_DECIMAL = "{0:C1}";
        public static string TWO_DECIMAL = "{0:C2}";

        public static string VIETNAM = "vi-VN";
        public static string ENGLISH = "en-US";

        public required string Format { get; set; }
        public required double Value { get; set; }
        public required string CultureInfor { get; set; }

        public override string ToString()
        {
            return string.Format(new CultureInfo(CultureInfor), Format, Value);
        }

        // override Clone method
        public TextCurrency Clone()
        {
            return (TextCurrency)MemberwiseClone();
        }
    }
}
