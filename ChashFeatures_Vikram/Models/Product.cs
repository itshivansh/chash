using System;
using System.Collections.Generic;
using System.Text;

namespace ChashFeatures_Vikram.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "LG";
        public DateTime LoginDateTime { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return string.Format($"{Id}-->{Name}-->{LoginDateTime}");
        }

        public static int TotalPrice(int basicPrice)
        {
            return TotalPrice(basicPrice);
            
            static int TotalPrice(int basePrice)
            {
                return basePrice + 10;
            }
        }


    }
}
