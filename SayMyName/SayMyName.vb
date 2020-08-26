'Doyle_Shaw
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/shawdoyl/Say-My-Name

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()

        Dim userMessage As String
        Console.WriteLine("Please enter your name. Press Enter when done.")
        userMessage = Console.ReadLine()
        Console.WriteLine("You entered " & userMessage & ", welcome " & userMessage & ".")
        Console.ReadLine()

    End Sub

End Module
