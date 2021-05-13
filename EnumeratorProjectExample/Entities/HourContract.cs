using System;
using System.Collections.Generic;
using System.Text;

namespace EnumeratorProjectExample.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerhour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerhour, int hours)
        {
            Date = date;
            ValuePerhour = valuePerhour;
            Hours = hours;
        }

        public double Totalvalue()
        {
            return Hours * ValuePerhour;
        }
    }
}
