using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Pointers
    {
        public double X1 { set; get; }
        public double Y1 { set; get; }
        public double X2 { set; get; }
        public double Y2 { set; get; }

        public double GetDistance()
        {
            double Xs = Math.Pow(X2 - X1, 2);
            double Ys = Math.Pow(Y2 - Y1, 2);
            return Math.Sqrt(Xs + Ys);
        }
    }
}