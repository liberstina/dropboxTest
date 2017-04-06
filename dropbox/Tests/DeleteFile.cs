class DeleteFile : BaseTest
    {
    public static String email = "liberstina@gmail.com";
    public static String password = "En4uJiF03d";
    public static String searchquery = "testfile";

        IWebDriver driver;
	private BaseSteps baseSteps;
	private LoginSteps loginSteps;
	private MainSteps mainSteps;

[Test]
        public void DeleteFileTest()
        {
	baseSteps.sign_in();
        loginSteps.sign_in_as(email, password);
	mainSteps.find_file(searchquery);
	mainSteps.delete_file();
	mainSteps.find_file(searchquery);
	mainSteps.no_results();
          
        }
       

    }