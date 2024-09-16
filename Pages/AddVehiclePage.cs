using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Pages
{
    
    public class AddVehiclePage
{
        private readonly IWebDriver _driver; // WebDriver instance

    // Constructor - WebDriver instance is injected into this class
    // Constructor - WebDriver instance is injected into this class
    public AddVehiclePage(IWebDriver driver)
    {
         _driver = driver;
    }

    // Element locators - Define elements on the login page
    
    [FindsBy(How = How.XPath, Using = "//span[@class='sidebar-title' and text()='Araçlar']")]
    private IWebElement VehicleTitle { get; set; } // Vehicle title element locator
    [FindsBy(How = How.XPath, Using = "//span[@class='sidebar-title' and text()='Araçlar']")]
    private IWebElement NameField => _driver.FindElement(By.Id("username")); // Email field locator
    [FindsBy(How = How.XPath, Using = "//span[@class='sidebar-title' and text()='Araçlar']")]
    private IWebElement PasswordField => _driver.FindElement(By.Id("password")); // Password field locator
    [FindsBy(How = How.XPath, Using = "//span[@class='sidebar-title' and text()='Araçlar']")]
    private IWebElement LoginButton => _driver.FindElement(By.Id("loginButton")); // Login button locator

    // Methods for interacting with the elements
    public void EnterName(string name)
    {
        NameField.Clear(); // Clear the field
        NameField.SendKeys(name); // Enter the email
    }

    public void EnterPassword(string password)
    {
        PasswordField.Clear(); // Clear the field
        PasswordField.SendKeys(password); // Enter the password
    }

    public void ClickLoginButton()
    {
        LoginButton.Click(); // Click the login button
    }

    // Method for performing the login action
    public void Login(string name, string password)
    {
        EnterName(name);
        EnterPassword(password);
        ClickLoginButton();
    }

    // Method to check if the page is loaded
    public bool IsAtLoginPage()
    {
        return _driver.Url.Contains("login"); // Check the URL
    }
}

    internal class FindsByAttribute : Attribute
    {
        public object How { get; set; }
        public string Using { get; set; }
    }
}