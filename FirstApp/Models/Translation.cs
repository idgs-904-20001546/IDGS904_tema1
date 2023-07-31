using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Translation
    {
        [DisplayName("Palabra Ingles")]
        public string EnWord { get; set; }

        [DisplayName("Palabra Español")]
        public string EsWord { get; set; }

        public string Selected { get; set; }

        [DisplayName("Palabra")]
        public string Word { get; set; }

        public override string ToString()
        {
            return this.EnWord.ToLower() + ":" + this.EsWord.ToLower() + Environment.NewLine;
        }

        public static Translation GetTranstionsFrom(string term)
        {
            return new Translation() { EnWord = term.Split(':')[0], EsWord = term.Split(':')[1] };
        }
    }
}