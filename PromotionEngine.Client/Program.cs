using PromotionEngine.Application.Product.Queries.GetTotalPrice;
using PromotionEngine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Product p1 = new Product();
				Product p2 = new Product();
				Product p3 = new Product();
				Product p4 = new Product();

                #region Scenario A

                GetTotalPriceQuery query_scenario_A = new GetTotalPriceQuery();
				query_scenario_A.Products = new List<Product>();

				p1.Id = "A";
				p1.ProductCount = 1;
				query_scenario_A.Products.Add(p1);

				p2.Id = "B";
				p2.ProductCount = 1;
				query_scenario_A.Products.Add(p2);

				p3.Id = "C";
				p3.ProductCount = 1;
				query_scenario_A.Products.Add(p3);
				
				GetTotalPriceQueryHandler handler_scenario_A = new GetTotalPriceQueryHandler();
				Console.WriteLine("Scenario A Total: " + handler_scenario_A.Handle(query_scenario_A.Products));

				#endregion

				#region Scenario B

				GetTotalPriceQuery query_scenario_B = new GetTotalPriceQuery();
				query_scenario_B.Products = new List<Product>();

				p1.Id = "A";
				p1.ProductCount = 5;
				query_scenario_B.Products.Add(p1);

				p2.Id = "B";
				p2.ProductCount = 5;
				query_scenario_B.Products.Add(p2);

				p3.Id = "C";
				p3.ProductCount = 1;
				query_scenario_B.Products.Add(p3);

				GetTotalPriceQueryHandler handler_scenario_B = new GetTotalPriceQueryHandler();
				Console.WriteLine("Scenario A Total: " + handler_scenario_B.Handle(query_scenario_B.Products));

				#endregion

				#region Scenario C

				GetTotalPriceQuery query_scenario_C = new GetTotalPriceQuery();
				query_scenario_C.Products = new List<Product>();

				p1.Id = "A";
				p1.ProductCount = 3;
				query_scenario_C.Products.Add(p1);

				p2.Id = "B";
				p2.ProductCount = 5;
				query_scenario_C.Products.Add(p2);

				p3.Id = "C";
				p3.ProductCount = 1;
				query_scenario_C.Products.Add(p3);

				p4.Id = "D";
				p4.ProductCount = 1;
				query_scenario_C.Products.Add(p4);

				GetTotalPriceQueryHandler handler_scenario_C = new GetTotalPriceQueryHandler();
				Console.WriteLine("Scenario C Total: " + handler_scenario_C.Handle(query_scenario_C.Products));

				#endregion

				Console.ReadKey();

			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
