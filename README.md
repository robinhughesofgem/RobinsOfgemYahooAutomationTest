# RobinsOfgemYahooAutomationTest
The automated testing tool in use at the moment is Selenium using the SpecFlow pattern and Page Object Model, this is currently only targeting Chrome.

Important!! - Please ensure the version of the package Selenium.Webdriver.Chromedriver you are using matches your current version of Chrome
If when running the tests you get a Yellow warning triangle, this is usually why.

The following details How to Upgrade Specflow to use Specflow Accounts if you have not already done so.

Upgrade Process:
First ensure that you have the Specflow For Visual Studio 2019 Extension installed on your Visual Studio. 
Rebuild the solution and attempt to run the tests from Test Explorer.
In the Output click the dropdown "Show output from" and select Tests.
In here you will see a blue URL link for creating an Account, ctrl + leftclick on this link.
Log in with your Microsoft Account and proceed to create an Account with Specflow.
You will see a confirmation that your account has been created.
Rebuild your test solution (you may have to exit and reopen VS or Run the tests).
In the Test Output you should now see:
"Checking activation.
Activated.
Activation check completed"
From the test explorer you can now run your tests.
