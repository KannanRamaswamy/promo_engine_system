using System;
using System.Collections.Generic;
using NUnit.Framework;
using PromotionEngine.Application.Product.Queries.GetTotalPrice;
using PromotionEngine.Domain.Entities;

namespace PromotionEngine.UnitTest
{

    public class Tests
    {
        Product p1;
        Product p2;
        Product p3;
        Product p4;

        [SetUp]
        public void Setup()
        {
            p1 = new Product();
            p2 = new Product();
            p3 = new Product();
            p4 = new Product();
        }


        [Test]
        public void Scenario_A()
        {

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
            int result = handler_scenario_A.Handle(query_scenario_A.Products);

            int expected = 100;
            if (expected == result)
                Assert.Pass();
            else
                Assert.Fail();

        }

        [Test]
        public void Scenario_B()
        {
            try
            {
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
                int result = handler_scenario_B.Handle(query_scenario_B.Products);

                int expected = 370;
                if (expected == result)
                    Assert.Pass();
                else
                    Assert.Fail();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Test]
        public void Scenario_C()
        {
            try
            {
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
                int result = handler_scenario_C.Handle(query_scenario_C.Products);

                int expected = 285;
                if (expected == result)
                    Assert.Pass();
                else
                    Assert.Fail();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
