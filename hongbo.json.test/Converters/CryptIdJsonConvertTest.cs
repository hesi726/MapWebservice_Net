using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Linq;

namespace hongbo.json.test.Converters
{
    [TestClass]
    public class CryptIdJsonConvertTest
    {
        [TestMethod]
        public void DeserialzeSingleOrArrayObject()
        {
            var person = new SingleOrArrayPerson { Id = 1234 };
            var personJson = JsonConvert.SerializeObject(person);
            typeof(SingleOrArrayPerson).GetProperty("Xid").GetCustomAttributes(true);
        }
    }

    
}
