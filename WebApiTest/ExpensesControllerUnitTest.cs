using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;

namespace WebApiTest
{
    [TestClass]
    public class ExpensesControllerUnitTest
    {
        [TestMethod]
        public void Get()
        {
            ExpensesController expensesController = new ExpensesController();
            IEnumerable<string> actualResponse = expensesController.Get();
            List<string> expectedResponse = new List<string>();
            expectedResponse.Add("expense1");
            expectedResponse.Add("expense2");
            CollectionAssert.AreEqual(expectedResponse, actualResponse.ToList<string>());
        }

        [TestMethod]
        public void GetById()
        {
            ExpensesController expensesController = new ExpensesController();
            string actualResponse = expensesController.Get(5);
            string expectedResponse = "expense";
            Assert.AreEqual(expectedResponse, actualResponse);
        }
    }
}
