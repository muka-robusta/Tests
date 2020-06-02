Feature: Bool Calculator
  We need to test bool calculator, in order to find out, is it works
  
@conjuction_checks
Scenario: Count simple conjunction of 1 and 0
  Given I have entered 1 into the calculator
  And I have entered the conjuction operation
  And I have entered 0 into the calculator
  When I press "Simplify function" in menu
  Then the result must be 0
  
@disjunction_test
Scenario: Count simple disjunction of 1 and 0
  Given I have entered 1 into the calculator
  And I have entered the disjunction operation
  And I have entered 0 into the calculator
  When I press "Simplify function" in menu
  Then the result must be 1
  
@simplify_function1
Scenario: Simplifying bool function
  Given I have entered function (A \ B) dis (!A /\ (B /\ A))
  When I press "Simplify function" in menu
  Then the result must be (A \ B)
  
Scenario: Count Zhegalkin polynomial
  Given I have entered bool function (A + B) conj A
  When I press "Count Zhegalkin polynomial" in menu
  Then the result must be A + AB
  
Scenario: Test Carno cards
  Given I have entered bool function (A + B) conj A
  When I press "Carno cards"
  Then must be table with values {{0,0}, {1,0}}
  
Scenario: Count disjunction normal form
  Given I have entered bool function (A + B) conj A
  When I press "Disjunction normal form" in menu
  Then the result must be (!AB disj. A!B)A
  
Scenario: Count The module-sum of two values
  Given I have entered 1 into the calculator
  And I have entered the + operation
  And I have entered 1 into the calculator
  When I pressed "Simplify function" in menu
  Then the result must be 0
  
Scenario: Count not operation
  Given I have entered 1 into the calculator
  And I put "NOT" operation before the value
  When I pressed "Simplify function" in menu
  Then the result must be 0
  
Scenario: Simplify the operation "consequence"
  Given I have entered A 
  And I put "consequence" operation as array icon
  And I entered B
  When I pressed "Simplify function" in menu
  Then the result must be !A disj. B