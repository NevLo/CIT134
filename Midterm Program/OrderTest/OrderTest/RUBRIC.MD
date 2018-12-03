Midterm - Restaurant Orders (150 Points)

 We will be creating an application that will allow the user to enter an order, 
 delete an order, or display the total of all orders in the system. 
 You will use techniques, methods, classes, and other statements we have 
 learned so far to accomplish this assignment. 
 Please follow all of the directions and then upload your completed midterm 
 to the Canvas module.



1.)    Create a new Console Application project in Visual Studio 2017 
        called “OrderTest.” Rename the Program.cs file to 
        OrderTest.cs. (10 points)

2.)    Inside the OrderTest class, but outside of the Main method, 
        create a new static Random object. (5 points)

3.)    Add a class to the project and call it “MyOrder.” In MyOrder there 
        should be a static decimal named Total available for public access. 
        There should also be the following members: (10 points)
            
            CustomerName (string)
            OrderNum(int)
            SubTotal(decimal)
            Item1(string)
            Item2(string)
            Item3(string)
            Item4(string)

4.)    Each of the members in MyOrder should have the appropriate get and set 
        properties. You can use the auto-implementation of the properties for this 
        midterm. (10 points)

5.)    In MyOrder create a method called “DisplayOrder” that uses all of the
        properties created in step 4 to print the order out to the console. 
        There should also be a default constructor and a constructor that takes
        7 arguments used to initialize the members of the class. (15 points)

6.)    In OrderTest class create two static methods: One called UpdateTotal
        that takes a decimal as an argument. This method will update the static
        Total variable of the MyOrder class, so the decimal passed to the 
        method is added to Total. The second static method should be called 
        DisplayTotal. This method takes no arguments but prints the Total 
        from the MyOrder class out to the console when called. (15 points)

7.)    In the Main method of OrderTest declare the following: (5 points)
        
            selection(char)
            orderEdit(int)
            orderNum(int)
            endMenu(bool) initialized to false

8.)    Create 3 objects of the MyOrder class called order1, order2, and order3.
        The first two should use the constructor that takes the 7 arguments as 
        follows: (123, "Fred_Flintstone", "Beef", "Rice", "Bread", "Milk", 56.75M)
        and (456, "Barney_Rubble", "Chicken", "Noodles", "Broth", "Soda", 48.25M). 
        Immediately after creating these objects you should add the SubTotal of 
        each order to the Total of the MyOrder class using the UpdateTotal method 
        from step 6. If working correctly then the following code is 
        how this will be accomplished…

            UpdateTotal(order1.SubTotal);

        The third object should use the default constructor. (10 points)

9.)    Prompt the user with the following info asking them to make a selection. 
        Replace the name "Topher" with your own name: (10 points)

            Welcome to Topher’s Restaurant!
            Please make a selection below...
            a) Begin an order
            b) Delete an order
            c) Display Total of All orders
            d) Exit

10.)    The user input should be assigned to the "selection" char variable 
        declared earlier. The "selection" should then be checked in a switch 
        statement. (10 points)

11.)    If 'a' is typed in then use the "Next()" method of the Random object 
        with an argument of 1000 to generate a random number between 0 and 999.
        This random number should be assigned to the orderNum variable. This is 
        the OrderNum of the order3 object created. Prompt the user to enter the 
        customer name (with no spaces), items 1-4, (with no spaces), and a 
        price for each item. Every time a price is entered add it to the 
        SubTotal member of the order3 object. Once all of the info has been 
        entered and assigned to the members of the object, call the UpdateTotal
        method with order3.SubTotal as the argument. 
        Then call the DisplayOrder method of the order3 object. (15 points)

12.)    If the user enters 'b' then ask the user if they wish to delete order 
        1 or order 2. The entered value should be assigned to the orderEdit 
        variable. Use an if/else statement on the orderEdit variable to decide 
        which of the orders to delete. You will not delete the order but set 
        all of the order's string values to "", subtract the SubTotal amount 
        from the static Total in the MyOrder class, and then set the SubTotal 
        amount of the order to 0.00. Call the DisplayOrder method on whichever 
        order has been deleted. (15 points)

13.)    If the user enters 'c' call the DisplayTotal method. (5 points)

14.)    If the user enters 'd' print out "Goodbye" to the console 
        and set the endMenu variable to true. (5 points)

15.)    The default of the switch should prompt the user to 
        please try again. (5 points)

16.)    The entire menu display and switch statement should be enclosed in a 
        do/while statement that executes until the endMenu variable 
        is set to true. (5 points)
 
