# Lambda

The Lambda project is a console application that demonstrates the usage of lambda expressions in C#. It includes creating a list of employees, filtering the employees based on specific criteria using both foreach loops and lambda expressions.

# Project Description
The Lambda project consists of a single file, Program.cs.

Program.cs

This file contains the Program class, which contains the Main method. In the Main method, the program creates a list of employees. Each employee has a first name, last name, and an Id. At least two employees have the first name "Joe".

The program uses a foreach loop to iterate over the list of employees and filters out all employees with the first name "Joe" into a new list called joeEmployees using an if statement.

Next, the program uses a lambda expression to filter the employees with the first name "Joe" into another new list called joeEmployeesLambda. The lambda expression uses the Where method from the System.Linq namespace to filter the employees based on the specified condition.

Finally, the program uses another lambda expression to filter the employees with an Id number greater than 5 into a new list called idGreaterThan5Employees. This lambda expression also uses the Where method to filter the employees based on the specified condition.

# Instructions
Start the console application.

The program will create a list of employees with first names, last names, and Ids.

The program will use a foreach loop to create a new list of employees with the first name "Joe" and store them in the joeEmployees list.

The program will use a lambda expression to create another new list of employees with the first name "Joe" and store them in the joeEmployeesLambda list.

The program will use a lambda expression to create a new list of employees with an Id number greater than 5 and store them in the idGreaterThan5Employees list.

The program will display the contents of the joeEmployees, joeEmployeesLambda, and idGreaterThan5Employees lists on the console.

The program will terminate.

You can rerun the program to test different scenarios and observe the filtering results.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to lambda expressions in C#:

Creating and manipulating lists of objects

Filtering objects from a list using foreach loops

Filtering objects from a list using lambda expressions and the Where method from the System.Linq namespace
