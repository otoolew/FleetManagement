using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlowManager.Models
{
    public class FormatService
    {
        public string AsReadableDate(DateTime dateTime)
        {
            return dateTime.ToString("d");
        }
        public string AsReadableYear(DateTime dateTime)
        {
            return dateTime.Year.ToString();
        }
    }
}
