Feature: ScenarioOutline
	Here whole test will run no. of times we provided example rows

Background: Pre-Condition
    Given User it at Bug zilla homepage
    And File a Bug link should be visible  


Scenario Outline: Create Bug Scenario of bug zilla web page 
	When User click on File a Bug link
	Then User should be at Login page
	When I provide the username password and click on login button
	Then User should be at enter bug page
	When I provide the "<severity>","<hardware>","<platform>" ,"<summary>" nad "<scenario>"
	And  click on submit button
	Then Bug shoud be created
	And User should be at search page
	When I click on logout button
	Then User should be logged out and should be in home page
	Examples: 
	| TestCases | severity | hardware  | platform | summary    |  scenario      |
	| A         | major    | Macintosh | Linux    | Summary -1 | Description -1 |
	| B         | major    | Macintosh | Linux    | Summary -2 | Description -2 |