using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest
{
    [TestClass]
    public class ExpensesControllerTest
    {
        [TestMethod]
        public void GetAllTest()
        {
            using (var client = new WebAPI())
            {
                client.BaseUri = new Uri("http://localhost:8086");
                IList<string> response = client.Expenses.GetAll();
                List<string> actualResponse = response.ToList<string>();
                List<string> expectedResponse = new List<string>();
                expectedResponse.Add("expense1");
                expectedResponse.Add("expense2");
                CollectionAssert.AreEquivalent(expectedResponse, actualResponse);
            }
        }

        [TestMethod]
        public void GetTest()
        {
            using (var client = new WebAPI())
            {
                client.BaseUri = new Uri("http://localhost:8086");
                string actualResponse = client.Expenses.Get(5);
                string expectedResponse = "expense";
                Assert.AreEqual(expectedResponse, actualResponse);
            }
        }
    }
}
