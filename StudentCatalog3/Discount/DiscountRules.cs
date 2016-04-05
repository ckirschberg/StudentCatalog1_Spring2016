using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Discount
{
    public class DiscountRules
    {
        //0 - 499.999: 0
        //500-1000: 10
        //1000- ?: 20

        public int Calculate(double amount)
        {
            if (amount < 500 && amount >= 0)
            {
                return 0;
            }
            else if (amount >= 500 && amount < 1000)
            {
                return 10;
            }
            else if (amount >= 1000)
            {
                return 20;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}