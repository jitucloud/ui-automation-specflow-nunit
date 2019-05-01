Feature: Login
	Verify if login works

@mytag
Scenario: login user as admin
	Given Go to the login page
	And I enter username and password
	| Username | Password |
	| admin    |admin     |
	When I click login
	Then I should see user logged in

@mytag
Scenario: login user as admin1
	Given Go to the login page
	And I enter username and password
	| Username | Password |
	| admin    |admin     |
	When I click login
	Then I should see user logged in
