using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApiTest
{
    //[TestClass]
    public class ValuesControllerTest
    {
        //[TestMethod]
        public void GetAllTest()
        {
            using (var client = new WebAPI())
            {
                client.BaseUri = new Uri("http://localhost:8086");
                IList<string> response = client.Values.GetAll();
                List<string> actualResponse = response.ToList<string>();
                List<string> expectedResponse = new List<string>();
                expectedResponse.Add("value1");
                expectedResponse.Add("value2");
                CollectionAssert.AreEquivalent(expectedResponse, actualResponse);
            }
        }

        //[TestMethod]
        public void GetTest()
        {
            using(var client = new WebAPI())
            {
                client.BaseUri = new Uri("http://localhost:8086");
                string actualResponse = client.Values.Get(5);
                string expectedResponse = "value";
                Assert.AreEqual(expectedResponse, actualResponse);
            }
        }

    }
}
