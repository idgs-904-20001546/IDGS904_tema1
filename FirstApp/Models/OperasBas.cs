using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }

        public string Operation { get; set; }

        public void Plus()
        {
            this.Res = this.Num1 + this.Num2;
        }

        public void Less()
        {
            this.Res =  this.Num1 - this.Num2;
        }

        public void Multiply()
        {
            this.Res = this.Num1 * this.Num2;
        }

        public void Division()
        {
            this.Res = this.Num1 / this.Num2;
        }

        public int Calculate()
        {
            switch (this.Operation)
            {
                case "plus":
                    this.Plus();
                    break;
                case "less":
                    this.Less();
                    break;
                case "multiply":
                    this.Multiply();
                    break;
                case "division":
                    this.Division();
                    break;
            }

            return this.Res;
        }
    }
}