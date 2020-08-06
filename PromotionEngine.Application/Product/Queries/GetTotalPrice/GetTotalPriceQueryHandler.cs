using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Application.Product.Queries.GetTotalPrice
{
    using PromotionEngine.Domain.Entities;
    public class GetTotalPriceQueryHandler
    {
        public int Handle(List<Product> products)
        {
            int countA = 0, countB = 0,countC = 0, countD = 0;           

            foreach (Product pr in products)
            {
                switch (pr.Id.ToUpper())
                {
                    case "A":                   
                        countA += pr.ProductCount;
                        break;
                    case "B":                   
                        countB += pr.ProductCount;
                        break;
                    case "C":                  
                        countC += pr.ProductCount;
                        break;
                    case "D":                   
                        countD += pr.ProductCount;
                        break;
                }
            }
            int totalPriceOfA = (countA / 3) * 130 + (countA % 3 * 50);
            int totalPriceOfB = (countB / 2) * 45 + (countB % 2 * 30);
            int totalPriceOfC = (countC * 20);
            int totalPriceOfD = (countD * 15);
            return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
        }
    }
}
