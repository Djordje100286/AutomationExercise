Feature: Products
	As a user
	I want to be able to work with Products section
	So I can choose product

@mytag
Scenario: User can search for products by typing them
	Given user opens products page
	When user enters product in search box
		And user clicks on magnifying-glass button
	Then user is redirected to 'Searched Products' section

Scenario: User can add product to cart
	Given user opens products page
	When user enters product in search box
		And user clicks on magnifying-glass button
	    And opens first search result
	    And user clicks on Add to Cart button
	    And proceeds to cart
	Then shopping cart will displayed with expected product inside