public class LoginPage : BasePage
    {
       public IWebDriver Driver;
	public BasePage(IWebDriver driver)
        {
            Driver = driver;
         }

        [FindsBy(How = How.id, Using = "pyxl936036215599522777")]
        private IWebElement email;


        [FindsBy(How = How.id, Using = "pyxl936036215599522780")]
        private IWebElement password;

        
        [FindsBy(How = How.xpath, Using = "pyxl936036215599522780")]
        private IWebElement signInBtn;

       
        public IWebElement Email() {
        return email;
    	}

    	public IWebElement Password() {
        return password;
    	}

    	public IWebElement SignInBtn() {
        return signInBtn;
    	}


}