Feature: Login
As a registered user of imdb.com 
I want to login
So that I can assess the lates movies


Background:
     Given I navigate to the site "https://www.imdb.com"
     When I click on Sign in
     And I Click Sign in with IMDb
     And I enter email address "richkome@yahoo.com"
    


@Login
Scenario: Login with valid details Happy path
When I enter password "Favour123"
And I click on Sign button
Then  I logged in and Kome displayed successfully



Scenario: Login with invalid details sad path
When I enter invalid password "Favourxxx"
And I click on Sign button
Then there was a problem displayed

