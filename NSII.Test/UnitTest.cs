using Newtonsoft.Json;

namespace NSII.Test
{
    public class Tests
    {
        private dynamic _data;

        [SetUp]
        public void Setup()
        {
            using (StreamReader r = new StreamReader(Path.Combine(TestContext.CurrentContext.TestDirectory, "data.json")))
            {
                string json = r.ReadToEnd();
                _data = JsonConvert.DeserializeObject(json) ?? Array.Empty<int>();
            }
        }
        [Test]
        public void Test()
        {
            Assert.Pass();
        }
    }
}