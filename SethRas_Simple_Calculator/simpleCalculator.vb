'Seth N Rasmussen
'RCET 0265
'Spring 2022
'Simple Calculator
'https://github.com/SethRas/SethRas_Simple_Calculator.git

Option Explicit On
Option Strict On
Module simpleCalculator

    Sub Main()
        'Declare inputs as string values I suppose you could 
        'declare them as int as well?
        Dim userInputA As String
        Dim userInputC As String

        'Greeting and prompt for initial input
        Console.WriteLine("Hello, please enter a number")
        userInputA = Console.ReadLine()

        'Prompt for second number
        Console.WriteLine("Please enter another number")
        userInputC = Console.ReadLine()

        'Create addition operator
        Console.WriteLine(CInt(userInputA) + CInt(userInputC))
        Console.ReadLine()

    End Sub

End Module