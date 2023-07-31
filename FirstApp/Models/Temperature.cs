using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Temperature
    {
        public double Degres { get; set; }
        public string Selected { get; set; }
        public double Result { get; set; }

        public void CalculateCelcius()
        {
            if (this.Selected == "Celsius")
            {
                this.Result = (this.Degres - 32) / 1.8;
            } else
            {
                this.Result = (this.Degres * 1.8) + 32;
            }
        } 
    }
}