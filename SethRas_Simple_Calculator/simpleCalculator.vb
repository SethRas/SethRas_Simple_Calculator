'Seth N Rasmussen
'RCET 0265
'Spring 2022
'Simple Calculator
'https://github.com/SethRas/SethRas_Simple_Calculator.git

Option Explicit On
Option Strict Off

Module simpleCalculator

    Sub Main()
        'Declare inputs as string values I suppose you could 
        'declare them as int as well?
        Dim userInputA As Integer
        Dim userInputB As Integer
        Dim choice As String

        'Greeting and prompt for initial input
        Console.WriteLine("This Calculator will add or Multiply Two numbers")
        Console.WriteLine("Hello, please enter a number")
        userInputA = Console.ReadLine()

        'Prompt for second number
        Console.WriteLine("Please enter another number")
        userInputB = Console.ReadLine()

        'Prompt for Operator
        Console.WriteLine("Select operation + or * ")
        choice = Console.ReadLine

        If choice = "+" Then
            Console.WriteLine(userInputA & "+" & userInputB & "=" & userInputA + userInputB)
        ElseIf choice = "*" Then
            Console.WriteLine(userInputA & "*" & userInputB & "=" & userInputA * userInputB)
        End If

        Console.ReadLine()

    End Sub

End Module