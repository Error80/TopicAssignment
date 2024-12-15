// Antonino Alan Tancinco
// Title: Topic Assignment
// Date December 14 2024

module Assignment6

// Running boolean
let mutable running = true

// Title
let title = "Calculator"

// Will loop until the user chooses to exit
while running = true do

    
    // Clear the Console
    System.Console.Clear()

    // Displays the title
    System.Console.WriteLine(title)

    // Add More boolean
    let mutable addMore = true

    // Option
    let mutable option = ""

    // Base Number
    let mutable strBaseNum = ""
    let mutable baseNum = 0.0

    // Modifier Number
    let mutable strModNum = ""
    let mutable ModNum = 0.0

    // Operator
    let mutable operator = ""

    // Controls wether the code may continue or not
    let mutable validation = false


    // Base number
    let ValidateBaseNum = 

        // Validate that the input is numeric
        while validation = false do
            try 
                
                // Ask the user to enter a number
                System.Console.WriteLine("\nEnter a number")
                strBaseNum <- System.Console.ReadLine()

                // Try to turn the number into a double
                baseNum <- System.Double.Parse(strBaseNum)

                // Continue if succesful
                validation <- true

            // If the value is not numeric
            with 
                | :? System.FormatException -> System.Console.WriteLine("Error: Input must be numeric\n")

    // Set the validation back to false
    validation <- false

    // Will loop until the user chooses reset or close
    while addMore = true do

        // Set the validation back to false
        validation <- false

        // Operator
        let ValidateOperator =

            // Will loop until the input is valid
            while validation = false do
            
                // Ask the user to enter an operator
                System.Console.WriteLine("\nEnter an arithmetic operator \n\"+\" = Addition \n\"-\" = Subtraction \n\"*\" = Multiplication  \n\"/\" = Division")
                operator <- System.Console.ReadLine()

                // Checks if the input is valid
                if operator = "+" || operator = "-" || operator = "*" || operator = "/" || operator = "x" then validation <- true
                else System.Console.WriteLine("Error: Input must either be +, -, *, or /\n")

        // Set the validation back to false
        validation <- false

        // Modifier Number
        let ValidateModNum = 

            // Validate that the input is numeric
            while validation = false do
                try 

                    // Ask the user to enter a number
                    System.Console.WriteLine("\nEnter another number")
                    strModNum <- System.Console.ReadLine()

                    // Try to turn the number into a double
                    ModNum <- System.Double.Parse(strModNum)

                    // Check if the user inputed an "/" and a 0
                    if ModNum = 0 && (operator = "/" || operator = "÷" ) then System.Console.WriteLine("Error: You can't divide by 0\n")
                    else
                        validation <- true
                with 
                    | :? System.FormatException -> System.Console.WriteLine("Error: Input must be numeric\n")


        // Calculate Result
        let mutable result = 0.0

        // Determine the formula based on the selected operator
        result <-
            if operator = "+" then baseNum + ModNum;
            elif operator = "-" then baseNum - ModNum
            elif operator = "*" || operator = "x" || operator = "×" then baseNum * ModNum
            elif operator = "/" || operator = "÷" then baseNum / ModNum
            else baseNum + ModNum

        // Rounds the result
        result <- System.Math.Round(result, 10)

        // Converts the result back to string
        let strResult = result.ToString()

        // Clears the Console
        System.Console.Clear()


        // Displays the title
        System.Console.WriteLine(title)


        // Display the result
        System.Console.WriteLine("\nThe awnser for " + strBaseNum + " " + operator + " " + strModNum + " is: " + strResult + " (" + strBaseNum + " " + operator + " " + strModNum + " = " + strResult + ")")

        // Set the validation back to false
        validation <- false

        // Will loop until the user inputs a b or c
        while validation = false do

            // Ask the user for an input
            System.Console.WriteLine("\nPick an option \nA = Input another number \nB = Reset \nC = Close")
            option <- System.Console.ReadLine()

            // Checks if the input is a b or c
            if option = "a" || option = "b" || option = "c" || option = "A" || option = "B" || option = "C" then validation <- true

            // If the user inputs something else
            else System.Console.WriteLine("Error: Input must either be A, B, or C")

        // add another number
        if option = "a" || option = "A" then
            baseNum <- result
            strBaseNum <- result.ToString()

        // reset
        elif option = "b" || option = "B" then addMore <- false

        // close
        elif option = "c" || option = "C" then 
            addMore <- false
            running <- false




