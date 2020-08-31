'Doyle_Shaw
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/shawdoyl/Say-My-Name

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()

        Dim userMessage As String
        Console.WriteLine("Please enter your name. Press Enter when done.")
        userMessage = Console.ReadLine()

        If userMessage = "Doyle" Then
            Console.WriteLine("Welcome back Tigerfang. Ready to continue?")
        ElseIf userMessage = "Joe" Then
            Console.WriteLine("Welcome  back user " & userMessage & ".")
        ElseIf userMessage = "Emily" Then
            Console.WriteLine("Welcome back user " & userMessage & ".")
        Else
            Console.WriteLine("Access is Denied.")
        End If

        Console.ReadLine()

    End Sub

End Module
