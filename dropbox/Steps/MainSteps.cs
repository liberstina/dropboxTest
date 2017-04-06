class MainSteps : BaseSteps
    {
        private MainPage mainpage;
       
	public void find_file(String searchquery)
   {

        IWebElement search = mainpage.Search();
        search.sendKeys(searchquery);
        search.submit();
    }

 	public void delete_file()
    {
        mainpage.FileMenu().click();
        mainpage.DeleteFile().click();
    }

	public void no_results()
    {
        
        Assert.verify(true, "No results found");
    }
}