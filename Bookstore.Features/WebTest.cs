using System.Configuration;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Bookstore.Features
{
    public class WebTest
    {
        [BeforeScenario]
        public void Setup()
        {
            Browser = new IE(createInNewProcess: true);
        }

        [AfterScenario]
        public void TearDown()
        {
            Browser.Close();
            Browser.Dispose();
        }

        public Browser Browser { get; private set; }

        public string BaseUrl
        {
            get { return ConfigurationManager.AppSettings["baseUrl"]; }
        }

        public TPage OpenPage<TPage>(string url)
            where TPage : Page, new()
        {
            Browser.GoTo(url);
            return Browser.Page<TPage>();
        }
    }
}
