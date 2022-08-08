Feature: DataTable

Background: Pre-Condition
    Given User it at Bug zilla homepage
    And File a Bug link should be visible    

Scenario: Login Scenario of bug zilla web page
    When User click on File a Bug link
    Then User should be at Login page
    When I provide the username password and click on login button
    Then User should be at enter bug page
    When I click on logout button
    Then User should be logged out and should be in home page
    

Scenario: Create Bug Scenario of bug zilla web page
    When User click on File a Bug link
    Then User should be at Login page
    When I provide the username password and click on login button
    Then User should be at enter bug page
    When I provide the severity , hardware, platform and scenario
        | severity | hardware  | platform | Summary    | scenario|
        | major    | Macintosh | Linux    | Summary -1 | Description -1 |
    And  click on submit button
    Then Bug shoud be created
    And User should be at search page
    When I click on logout button
    Then User should be logged out and should be in home page