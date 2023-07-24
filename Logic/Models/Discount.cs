using Logic.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    [JsonObject]
    public class Discount
    {
        public Fillters ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public int DiscountPercentage { get; set; }
        public Discount(Fillters name, string value, int percentage)
        {
            ParameterName = name;
            ParameterValue = value;
            DiscountPercentage = percentage;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is Discount discount)
            {
                if (discount.ParameterName == ParameterName && discount.ParameterValue == ParameterValue && DiscountPercentage == discount.DiscountPercentage)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return $"paremeter:{ParameterName}, value:{ParameterValue}, discount perecentage: {DiscountPercentage}";
        }
    }
}
