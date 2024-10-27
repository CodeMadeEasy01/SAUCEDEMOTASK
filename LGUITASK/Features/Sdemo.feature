Feature: sauce Demo UI 


@mytag
Scenario:  Sauce Demo Site
	Given I am on sauce demo site 
	And  I enter accepted  username 
	And  I enter accepted  password
	Then  I Click on Login Button 

	@addCart
Scenario:  Add to Cart
	Given  I am on sauce demo site 
	And  I enter accepted  username 
	And  I enter accepted  password
	And  I Click on Login Button 
	And  I click on Add to Cart Button
	And  I click on Shopping Cart 
	And  I click on CheckOut Button
	Then I successfully see check information displayed 
	

	@lockOut
Scenario:  Locked-Out User
	Given I am on sauce demo site 
	And  I enter locked-out-user username 
	And  I enter accepted  password
	And  I Click on Login Button 
	Then  user  successfully see error message displayed


	@problemUser
Scenario: problem User
	Given  I am on sauce demo site 
	And  I enter problem_user username
	And  I enter accepted  password
	And  I Click on Login Button 
	And  I click on Shopping Cart 
	And  I click on CheckOut Button
	Then I successfully see check information displayed   






