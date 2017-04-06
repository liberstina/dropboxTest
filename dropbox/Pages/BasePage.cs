public class BasePage
    {
	public IWebDriver Driver;
	public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
       
        [FindsBy(How = How.id, Using = "sign-in")]
        private IWebElement signIn;


        public IWebElement SignIn() {
        return signIn;
    		}

	}

    }