class BaseTest
    {
   
       [TestFixtureSetUp]
        public static void Init()
        {
            XmlConfigurator.Configure();
            
            Driver.DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60)));
            Driver.DriverInstance.Manage().Window.Maximize();
        }

        [TestFixtureTearDown]
        public static void Close()
        {
            Driver.Close();
        }

        [SetUp]
        public void Open()
        {
            Driver.DriverInstance.Navigate().GoToUrl(ConfigurationManager.AppSettings["https://www.dropbox.com/"]);
        }

        [TearDown]
        public void CleanUp()
        {
        
            Driver.DriverInstance.Manage().Cookies.DeleteAllCookies();
        }
	
    }

