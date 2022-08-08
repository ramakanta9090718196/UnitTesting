Feature: Argument
Background: Pre-Condition
	#Given Step
	Given User it at Bug zilla homepage with url "http://localhost:5001/"
	And File a Bug link should be visible 

Scenario: Login Scenario of bug zilla web page
    When User click on "File a Bug" link
    Then User should be at Login page
    When I provide the "ramakanta.das9090718196@outlook.com" "Bugzilla@1996" and click on login button
    Then User should be at enter bug page
    When I click on logout button
    Then User should be logged out and should be in home page
