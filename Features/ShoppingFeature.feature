Feature: Shopping
	As a user of a shopping website
	I want to add and remove items on the cart
	So that i can verify items in my cart

@Regressiontest
Scenario: To verify if i can add and remove selected items in the cart
	Given I add four random items to my cart.
	When I view my cart.
	Then I find total four items listed in my cart.
	When I search for the lowest price item.
	And I am able to remove the lowest price item from my cart.
	Then I am able to verify three items in my cart.