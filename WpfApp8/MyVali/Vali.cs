using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp8
{
    public class MinLength:ValidationRule
    {
        public int MinLen { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str= value as string;
            if (str == null)
                return new ValidationResult(false, "can't be null");
            if (str.Length<MinLen)
            {
                return new ValidationResult(false,"too short");
            }
            return new ValidationResult(true,null);
        }
    }
    public class MaxLength : ValidationRule
    {
        public int MaxLen { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if (str == null)
                return new ValidationResult(false, "can't be null");
            if (str.Length > MaxLen)
            {
                return new ValidationResult(false, "too long");
            }
            return new ValidationResult(true, null);
        }
    }
    public class Weight : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            double h;
            if (str == null)
                return new ValidationResult(false, "empty");
            if (Double.TryParse(str, out h))
            {
                if(h<=0)
                    return new ValidationResult(false, "must be higher than zero");
                return new ValidationResult(true,null);
            }
            return new ValidationResult(false, "must be a number");
        }
    }
    public class Birth : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            DateTime d;
            DateTime current = DateTime.Now.Date;
            if (str == null)
                return new ValidationResult(false, "empty");
            if (DateTime.TryParse(str, out d))
            {
                d = d.Date;
                if (d > current)
                    return new ValidationResult(false, "date error");
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false, "incorrect parameters");
        }
    }
    public class Gender : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            char c;
            if (str == null)
                return new ValidationResult(false, "can't be null");
            if(char.TryParse(str, out c))
            {
                if (c == 'F' || c == 'M' || c == 'f' || c == 'm')
                {
                    return new ValidationResult(true, null);
                }
            }        
            return new ValidationResult(false, "incorrect parameters");
        }
    }

}
