public class Driver
    {
        private static IWebDriver driverInstance;

public static IWebDriver DriverInstance
        {
            get
            {

	private static Func<IWebDriver> DriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Firefox:
                    return () => new FirefoxDriver("C:\\ProgramFiles\\Drivers");
                case BrowserType.Chrome:
                    return () => new ChromeDriver("C:\\ProgramFiles\\Drivers");
                case BrowserType.IE:
                    return () => new InternetExplorerDriver("C:\\ProgramFiles\\Drivers");
                default:
                    return () => new FirefoxDriver();
            }
	}
		}

        }
        

        public static void Close()
        {
            if (driverInstance != null)
            {
                driverInstance.Quit();
                driverInstance = null;
            }
        }
    }