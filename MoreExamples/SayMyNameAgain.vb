'Brandon Barrera
'Spring 2025
'RCET2265
'Say My Name... Again
'

Option Explicit On
Option Strict On
Option Compare Text

Module SayMyNameAgain

    Sub Main()

        Dim userName As String

        Console.WriteLine("Please enter your name.")
        userName = Console.ReadLine
        Console.WriteLine()

        If userName = "Emily" Then
            Console.WriteLine("Hello Emily!")
        ElseIf userName = "Joe" Then
            Console.WriteLine("We meet again Joe...")
        ElseIf userName = "Brandon" Then
            Console.WriteLine("Welcome home Mr.BrandLeBar")
        Else Console.WriteLine($"Hello")
        End If

    End Sub

End Module
