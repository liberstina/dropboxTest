class LoginSteps : BaseSteps
    {
    private LoginPage loginpage;
       
	public void sign_in_as(String email, String password)
{
   	IWebElement emailInput = loginpage.Email();
        loginpage.Email().sendKeys(email);
        IWebElement passwordInput = password.Email();
        loginpage.Password().sendKeys(password);
        loginpage.SignInBtn().click();
    }
       

}