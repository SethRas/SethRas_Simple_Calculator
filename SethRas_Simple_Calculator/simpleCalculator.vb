'Seth N Rasmussen
'RCET 0265
'Spring 2022
'Simple Calculator
'https://github.com/SethRas/SethRas_Simple_Calculator.git

Option Explicit On
Option Strict On

Module simpleCalculator

    Sub Main()
        Dim userInputA As String
        Dim userInputC As String

        Console.WriteLine("Hello, please enter a number")
        userInputA = Console.ReadLine()

        Console.WriteLine("Please enter another number")
        userInputC = Console.ReadLine()

        Console.WriteLine(CInt(userInputA) + CInt(userInputC))
        Console.ReadLine()

    End Sub

End Module
