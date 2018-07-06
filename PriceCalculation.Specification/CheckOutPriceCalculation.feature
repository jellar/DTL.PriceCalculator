Feature: CheckOutPriceCalculation
	In order to get products total
	As a shop owner
	I want to calculate total products amount with offers included 

@mytag
Scenario: Customer buys 1 butter, 1 milk and 1 butter
	Given the basket has
		| Quantity | Name   | Price |
		| 1        | bread  | 1.00  |
		| 1        | butter | 0.80  |
		| 1        | milk   | 1.15  |	
	When I calculate checkout total
	Then the total price should be 2.95

Scenario: Customer buys 2 butter, 2 butter
	Given the basket has
		| Quantity | Name   | Price |
		| 2        | butter | 0.80  |	
		| 2        | bread  | 1.00  |
	When I calculate checkout total
	Then the total price should be 3.10

Scenario: Customer buys 4 milk
	Given the basket has
		| Quantity | Name   | Price |
		| 4        | milk	| 1.15  |
	When I calculate checkout total
	Then the total price should be 3.45

Scenario: Customer buys 2 butter, 8 milk and 1 butter
	Given the basket has
		| Quantity | Name   | Price |
		| 1        | bread  | 1.00  |
		| 2        | butter | 0.80  |
		| 8        | milk   | 1.15  |	
	When I calculate checkout total
	Then the total price should be 9.00
