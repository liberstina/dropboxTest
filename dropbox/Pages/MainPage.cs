class MainPage :  BasePage
    {

	public IWebDriver Driver;
	public BasePage(IWebDriver driver)
        {
            Driver = driver;
         }
       

        [FindsBy(How = How.id, Using = "component5665937057110979534")]
        private IWebElement search;


        [FindsBy(How = How.xpath, Using = "//*[@id=\"bubbleDropdownTarget-29\"]/span/svg")]
        private IWebElement fileMenu

        
        [FindsBy(How = How.xpath, Using = "/html/body/div[1]/div/div/div/div/ul/li[6]/a")]
        private IWebElement deleteFile;


 	[FindsBy(How = How.xpath, Using = "//*[@id=\"component6570836622153841248\"]/div/main/div[1]/div/div[2]/div[1]/h2")]
        private IWebElement noResults;


        public IWebElement Search() {
        return search;
    }
    	public IWebElement FileMenu() {
        return fileMenu;
    }

    	public IWebElement DeleteFile() {
        return deleteFile;
    }

    	public IWebElement NoResults() {
        return noResults;
    }
     
}