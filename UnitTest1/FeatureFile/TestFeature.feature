Feature: Login and create Bug of BugZilla web page

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
    When I provide the severity , harware, platform and scenario
    And  click on submit button
    Then Bug shoud be created
    And User should be at search page
    When I click on logout button
    Then User should be logged out and should be in home page