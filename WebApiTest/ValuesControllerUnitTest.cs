using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;

namespace WebApiTest
{
    [TestClass]
    public class ValuesControllerUnitTest
    {
        [TestMethod]
        public void Get()
        {
            ValuesController valuesController = new ValuesController();
            IEnumerable<string> actualResponse = valuesController.Get();
            List<string> expectedResponse = new List<string>();
            expectedResponse.Add("value1");
            expectedResponse.Add("value2");
            CollectionAssert.AreEqual(expectedResponse, actualResponse.ToList<string>());
        }

        [TestMethod]
        public void GetById()
        {
            ValuesController valuesController = new ValuesController();
            string actualResponse = valuesController.Get(5);
            string expectedResponse = "value";
            Assert.AreEqual(expectedResponse, actualResponse);
        }
    }
}
