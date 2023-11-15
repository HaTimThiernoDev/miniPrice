using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPriceApp
{
    public class MiniPrice
    {
        public double PrixInitial { get; set; }
        public double Taux { get; set; }
        public DateTime Jour { get; set; }  
        public  double CalculerPrixFutur(MiniPrice miniPrice)
        {
            TimeSpan difference = miniPrice.Jour - new  DateTime(2023,11,10);
            int jours = (int)difference.TotalDays;

            double prixFutur = miniPrice.PrixInitial * Math.Pow((1 + miniPrice.Taux), jours);
            return Math.Round(prixFutur, 2);
        }
    }
}
