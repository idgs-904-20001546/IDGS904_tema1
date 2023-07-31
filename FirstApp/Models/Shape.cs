using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Shape
    {
        public double X1 {  get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }  
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Y3 { get; set; }

        public double L1()
        {
            double Xs = Math.Pow(X2 - X1, 2);
            double Ys = Math.Pow(Y2 - Y1, 2);
            return Math.Round(Math.Sqrt(Xs + Ys), 2);
        }
        public double L2()
        {
            double Xs = Math.Pow(X3 - X2, 2);
            double Ys = Math.Pow(Y3 - Y2, 2);
            return Math.Round(Math.Sqrt(Xs + Ys), 2);
        }
        public double L3()
        {
            double Xs = Math.Pow(X1 - X3, 2);
            double Ys = Math.Pow(Y1 - Y3, 2);
            return Math.Round(Math.Sqrt(Xs + Ys), 2);
        }
        public bool IsTriangle()
        {
            List<double> lines = new List<double>() { L1(), L2(), L3() };
            lines.Sort();
            if ((lines[0] + lines[1]) <= lines[2])
            {
                return false;
            }

            return true;
        }

        public string GetTypeTriangle()
        {
            var lines = new HashSet<double>() { L1(), L2(), L3() }.ToList();
            return lines.Count == 1 ? "equilatero" : lines.Count == 2 ? "isoseles" : "escaleno";
        }

        public double GetArea()
        {
            double s = (L1() + L2() + L3()) / 2;
            double area = Math.Sqrt(s * (s - L1()) * (s - L2()) * (s - L3()));
            return area;
        } 

    }   
}